using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
  public partial class FrmInventory : Form
  {
    public FrmInventory()
    {
      InitializeComponent();
      if (Game.player.equippedArmor == null)
      {
        this.pictureBoxArmorEquip.Hide();
      }
      else
      {
        this.pictureBoxArmorEquip.Show();
      }
      if (Game.player.equippedWep == null)
      {
        this.pictureBoxSwordEquip.Hide();
      }
      else
      {
        this.pictureBoxSwordEquip.Show();
      }
      this.SetStrengthArmorLabels();
    }

    public void FrmInventory_Load()
    {
      var inventory = Game.player.items;
      foreach (var item in inventory)
      {
        var row = new string[] { item.Name, item.Type, item.Value.ToString() };
        var lvi = new ListViewItem(row);
        lvi.Tag = item;
        listViewInventory.Items.Add(lvi);
      }
      this.SetStrengthArmorLabels();
    }

    public void RefreshInventory()
    {
      listViewInventory.Items.Clear();
      foreach (var item in Game.player.items)
      {
        var row = new string[] { item.Name, item.Type, item.Value.ToString() };
        var lvi = new ListViewItem(row);
        lvi.Tag = item;
        listViewInventory.Items.Add(lvi);
        listViewInventory.Refresh();
      }
    }

    private void ListViewInventory_DoubleClick(object sender, EventArgs e)
    {
      var selectedItem = (Item)listViewInventory.SelectedItems[0].Tag;
      var newInventory = new List<Item>();
      listViewInventory.Items.Clear();
      foreach (var item in Game.player.items)
      {
        var row = new string[] { item.Name, item.Type, item.Value.ToString() };
        var lvi = new ListViewItem(row);
        lvi.Tag = item;
        bool TypeNotAlreadyEquipped = ((selectedItem.Type == "armor" && Game.player.equippedArmor == null) || (selectedItem.Type == "weapon" && Game.player.equippedWep == null));
        if (selectedItem == item && TypeNotAlreadyEquipped)
        {
          if (item.Type == "weapon")
          {
            Game.player.AlterStrength(item.Value);
            Game.player.equippedWep = item;
            this.pictureBoxSwordEquip.Show();

          }
          else if (item.Type == "armor")
          {
            Game.player.armor += item.Value;
            Game.player.equippedArmor = item;
            this.pictureBoxArmorEquip.Show();
          }
          listViewInventory.Items.Remove(lvi);
          newInventory.Remove(item);
        }
        else
        {
          newInventory.Add(item);
          listViewInventory.Items.Add(lvi);
        }
      }
      Game.player.items = newInventory;
      listViewInventory.Refresh();
      this.SetStrengthArmorLabels();
    }

    private void SetStrengthArmorLabels()
    {
      this.lblArmor.Text = Game.player.armor.ToString();
      this.lblStrength.Text = Game.player.strength.ToString();
    }

    private void PictureBoxSwordEquip_Click(object sender, EventArgs e)
    {
      Item item = Game.player.equippedWep;
      int value = Game.player.equippedWep.Value;
      Game.player.equippedWep = null;
      Game.player.AlterStrength(-value);
      this.pictureBoxSwordEquip.Hide();

      var row = new string[] { item.Name, item.Type, item.Value.ToString() };
      var lvi = new ListViewItem(row);
      listViewInventory.Items.Add(lvi);
      Game.player.items.Add(item);
      listViewInventory.Refresh();
      this.RefreshInventory();
      this.SetStrengthArmorLabels();
    }

    private void PictureBoxArmorEquip_Click(object sender, EventArgs e)
    {
      Item item = Game.player.equippedArmor;
      int value = Game.player.equippedArmor.Value;
      Game.player.equippedArmor = null;
      Game.player.armor -= value;
      this.pictureBoxArmorEquip.Hide();

      var row = new string[] { item.Name, item.Type, item.Value.ToString() };
      var lvi = new ListViewItem(row);
      listViewInventory.Items.Add(lvi);
      Game.player.items.Add(item);
      listViewInventory.Refresh();
      this.RefreshInventory();
      this.SetStrengthArmorLabels();
    }
  }
}
