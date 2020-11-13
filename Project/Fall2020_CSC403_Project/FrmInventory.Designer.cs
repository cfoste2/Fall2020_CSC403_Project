namespace Fall2020_CSC403_Project
{
  partial class FrmInventory
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblStrength = new System.Windows.Forms.Label();
      this.lblArmor = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.labelWeapon = new System.Windows.Forms.Label();
      this.labelArmor = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.listViewInventory = new System.Windows.Forms.ListView();
      this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.pictureBoxArmorEquip = new System.Windows.Forms.PictureBox();
      this.pictureBoxSwordEquip = new System.Windows.Forms.PictureBox();
      this.pictureBoxWep = new System.Windows.Forms.PictureBox();
      this.pictureBoxArmor = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblHealth = new System.Windows.Forms.Label();
      this.lblMaxHealth = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblLevel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorEquip)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordEquip)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmor)).BeginInit();
      this.SuspendLayout();
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(247, 196);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(62, 24);
      this.label6.TabIndex = 25;
      this.label6.Text = "Armor";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(236, 243);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 24);
      this.label5.TabIndex = 24;
      this.label5.Text = "Strength";
      // 
      // lblStrength
      // 
      this.lblStrength.BackColor = System.Drawing.Color.Transparent;
      this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStrength.ForeColor = System.Drawing.Color.Black;
      this.lblStrength.Location = new System.Drawing.Point(335, 243);
      this.lblStrength.Name = "lblStrength";
      this.lblStrength.Size = new System.Drawing.Size(56, 31);
      this.lblStrength.TabIndex = 23;
      this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblArmor
      // 
      this.lblArmor.BackColor = System.Drawing.Color.Transparent;
      this.lblArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblArmor.ForeColor = System.Drawing.Color.Black;
      this.lblArmor.Location = new System.Drawing.Point(335, 196);
      this.lblArmor.Name = "lblArmor";
      this.lblArmor.Size = new System.Drawing.Size(56, 31);
      this.lblArmor.TabIndex = 22;
      this.lblArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(311, 44);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 96);
      this.label3.TabIndex = 21;
      this.label3.Text = "Stats";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(111, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 96);
      this.label2.TabIndex = 20;
      this.label2.Text = "Equipped Gear";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelWeapon
      // 
      this.labelWeapon.AutoSize = true;
      this.labelWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWeapon.Location = new System.Drawing.Point(17, 310);
      this.labelWeapon.Name = "labelWeapon";
      this.labelWeapon.Size = new System.Drawing.Size(92, 25);
      this.labelWeapon.TabIndex = 19;
      this.labelWeapon.Text = "Weapon";
      // 
      // labelArmor
      // 
      this.labelArmor.AutoSize = true;
      this.labelArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelArmor.Location = new System.Drawing.Point(38, 170);
      this.labelArmor.Name = "labelArmor";
      this.labelArmor.Size = new System.Drawing.Size(69, 25);
      this.labelArmor.TabIndex = 18;
      this.labelArmor.Text = "Armor";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(565, 62);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(180, 44);
      this.label4.TabIndex = 17;
      this.label4.Text = "Inventory";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // listViewInventory
      // 
      this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemName,
            this.colType,
            this.colValue});
      this.listViewInventory.Location = new System.Drawing.Point(522, 109);
      this.listViewInventory.Name = "listViewInventory";
      this.listViewInventory.Size = new System.Drawing.Size(262, 299);
      this.listViewInventory.TabIndex = 16;
      this.listViewInventory.UseCompatibleStateImageBehavior = false;
      this.listViewInventory.View = System.Windows.Forms.View.Details;
      this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.ListViewInventory_SelectedIndexChanged);
      // 
      // colItemName
      // 
      this.colItemName.Text = "Name";
      this.colItemName.Width = 87;
      // 
      // colType
      // 
      this.colType.Text = "Type";
      this.colType.Width = 75;
      // 
      // colValue
      // 
      this.colValue.Text = "Value";
      this.colValue.Width = 109;
      // 
      // pictureBoxArmorEquip
      // 
      this.pictureBoxArmorEquip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArmorEquip.BackgroundImage")));
      this.pictureBoxArmorEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxArmorEquip.InitialImage = null;
      this.pictureBoxArmorEquip.Location = new System.Drawing.Point(112, 143);
      this.pictureBoxArmorEquip.Name = "pictureBoxArmorEquip";
      this.pictureBoxArmorEquip.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxArmorEquip.TabIndex = 29;
      this.pictureBoxArmorEquip.TabStop = false;
      this.pictureBoxArmorEquip.Click += new System.EventHandler(this.PictureBoxArmorEquip_Click_1);
      // 
      // pictureBoxSwordEquip
      // 
      this.pictureBoxSwordEquip.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.swordInven;
      this.pictureBoxSwordEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxSwordEquip.InitialImage = null;
      this.pictureBoxSwordEquip.Location = new System.Drawing.Point(112, 274);
      this.pictureBoxSwordEquip.Name = "pictureBoxSwordEquip";
      this.pictureBoxSwordEquip.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxSwordEquip.TabIndex = 28;
      this.pictureBoxSwordEquip.TabStop = false;
      this.pictureBoxSwordEquip.Click += new System.EventHandler(this.PictureBoxSwordEquip_Click_1);
      // 
      // pictureBoxWep
      // 
      this.pictureBoxWep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWep.BackgroundImage")));
      this.pictureBoxWep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxWep.InitialImage = null;
      this.pictureBoxWep.Location = new System.Drawing.Point(112, 274);
      this.pictureBoxWep.Name = "pictureBoxWep";
      this.pictureBoxWep.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxWep.TabIndex = 27;
      this.pictureBoxWep.TabStop = false;
      // 
      // pictureBoxArmor
      // 
      this.pictureBoxArmor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArmor.BackgroundImage")));
      this.pictureBoxArmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxArmor.InitialImage = null;
      this.pictureBoxArmor.Location = new System.Drawing.Point(112, 143);
      this.pictureBoxArmor.Name = "pictureBoxArmor";
      this.pictureBoxArmor.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxArmor.TabIndex = 26;
      this.pictureBoxArmor.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(252, 301);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 24);
      this.label1.TabIndex = 31;
      this.label1.Text = "Health";
      // 
      // lblHealth
      // 
      this.lblHealth.BackColor = System.Drawing.Color.Transparent;
      this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHealth.ForeColor = System.Drawing.Color.Black;
      this.lblHealth.Location = new System.Drawing.Point(321, 297);
      this.lblHealth.Name = "lblHealth";
      this.lblHealth.Size = new System.Drawing.Size(46, 31);
      this.lblHealth.TabIndex = 30;
      this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblMaxHealth
      // 
      this.lblMaxHealth.BackColor = System.Drawing.Color.Transparent;
      this.lblMaxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMaxHealth.ForeColor = System.Drawing.Color.Black;
      this.lblMaxHealth.Location = new System.Drawing.Point(382, 294);
      this.lblMaxHealth.Name = "lblMaxHealth";
      this.lblMaxHealth.Size = new System.Drawing.Size(40, 31);
      this.lblMaxHealth.TabIndex = 32;
      this.lblMaxHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.Black;
      this.label7.Location = new System.Drawing.Point(363, 296);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(19, 31);
      this.label7.TabIndex = 33;
      this.label7.Text = "/";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(254, 143);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(55, 24);
      this.label9.TabIndex = 34;
      this.label9.Text = "Level";
      // 
      // lblLevel
      // 
      this.lblLevel.BackColor = System.Drawing.Color.Transparent;
      this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLevel.ForeColor = System.Drawing.Color.Black;
      this.lblLevel.Location = new System.Drawing.Point(335, 138);
      this.lblLevel.Name = "lblLevel";
      this.lblLevel.Size = new System.Drawing.Size(56, 31);
      this.lblLevel.TabIndex = 35;
      this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FrmInventory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblLevel);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblMaxHealth);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblHealth);
      this.Controls.Add(this.pictureBoxArmorEquip);
      this.Controls.Add(this.pictureBoxSwordEquip);
      this.Controls.Add(this.pictureBoxWep);
      this.Controls.Add(this.pictureBoxArmor);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblStrength);
      this.Controls.Add(this.lblArmor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.labelWeapon);
      this.Controls.Add(this.labelArmor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.listViewInventory);
      this.Name = "FrmInventory";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorEquip)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordEquip)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblStrength;
    private System.Windows.Forms.Label lblArmor;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelWeapon;
    private System.Windows.Forms.Label labelArmor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListView listViewInventory;
    private System.Windows.Forms.ColumnHeader colItemName;
    private System.Windows.Forms.ColumnHeader colType;
    private System.Windows.Forms.ColumnHeader colValue;
    private System.Windows.Forms.PictureBox pictureBoxArmorEquip;
    private System.Windows.Forms.PictureBox pictureBoxSwordEquip;
    private System.Windows.Forms.PictureBox pictureBoxWep;
    private System.Windows.Forms.PictureBox pictureBoxArmor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblHealth;
    private System.Windows.Forms.Label lblMaxHealth;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblLevel;
  }
}