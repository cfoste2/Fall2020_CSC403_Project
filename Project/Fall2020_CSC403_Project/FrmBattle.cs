﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {

  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private Results link;
    
    // this variable will be multiplied to health losses (changed upon conversion of player to knight avatar)
    public static int healthMultEnemy = 1;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
      
      // show experience
      UpdateExpBars();
      
      // show player level
      UpdatePlayerLevel();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy, ref Results link) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
                instance.link = link;
                instance.Setup();

      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
      
      if (playerHealthPer <= .25) {
        picPlayer2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player_lohp;
        link.lowHP = true;
      }
      else
      {
        link.lowHP = false;
      }
    }

    private void UpdateExpBars() {
      //float playerExp = (player.Experience + enemy.ExperienceDrop) / (float)player.RequiredLevelExperience;
      float playerExp = (player.Experience) / (float)player.RequiredLevelExperience;
      
      const int MAX_EXPBAR_WIDTH = 226;
      PlayerExperience.Width = (int)(MAX_EXPBAR_WIDTH * playerExp);

      PlayerExperience.Text = player.Experience.ToString();
    }
    
    private void UpdatePlayerLevel() {
      lblPlayerLevel.Text = player.Level.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-3 + player.armor);
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        if (enemy.Health <= 0) {
          link.enemyKO = true;
          player.AlterExperience(enemy.ExperienceDrop);
          UpdateExpBars();
          
          // If the player levels up, increase their level by 1, and increase the amount of exp needed to lvl up
          if (player.Experience >= player.RequiredLevelExperience)
          {
            player.LevelUp();

            // Each level requires more exp than the previous; reset user's exp to 0 for the next level
            player.AlterExperience(-(player.Experience));
            player.ScaleLevelExperience(50);
            
            // Restore the player back to max health each time they level up
            player.AlterHealth((player.MaxHealth - player.Health));
            
          }
        }
        link.running = false;
        instance = null;
        enemy.Hide();
        Close();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth((amount * healthMultEnemy));
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
