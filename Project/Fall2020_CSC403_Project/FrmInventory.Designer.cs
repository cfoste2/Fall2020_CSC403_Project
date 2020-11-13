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
      this.listViewInventory = new System.Windows.Forms.ListView();
      this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label1 = new System.Windows.Forms.Label();
      this.labelArmor = new System.Windows.Forms.Label();
      this.labelWeapon = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBoxArmor = new System.Windows.Forms.PictureBox();
      this.pictureBoxWep = new System.Windows.Forms.PictureBox();
      this.pictureBoxSwordEquip = new System.Windows.Forms.PictureBox();
      this.pictureBoxArmorEquip = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblArmor = new System.Windows.Forms.Label();
      this.lblStrength = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordEquip)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorEquip)).BeginInit();
      this.SuspendLayout();
      // 
      // listViewInventory
      // 
      this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemName,
            this.colType,
            this.colValue});
      this.listViewInventory.Location = new System.Drawing.Point(515, 100);
      this.listViewInventory.Name = "listViewInventory";
      this.listViewInventory.Size = new System.Drawing.Size(262, 299);
      this.listViewInventory.TabIndex = 2;
      this.listViewInventory.UseCompatibleStateImageBehavior = false;
      this.listViewInventory.View = System.Windows.Forms.View.Details;
      this.listViewInventory.DoubleClick += new System.EventHandler(this.ListViewInventory_DoubleClick);
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
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(558, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 44);
      this.label1.TabIndex = 3;
      this.label1.Text = "Inventory";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelArmor
      // 
      this.labelArmor.AutoSize = true;
      this.labelArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelArmor.Location = new System.Drawing.Point(31, 161);
      this.labelArmor.Name = "labelArmor";
      this.labelArmor.Size = new System.Drawing.Size(69, 25);
      this.labelArmor.TabIndex = 4;
      this.labelArmor.Text = "Armor";
      // 
      // labelWeapon
      // 
      this.labelWeapon.AutoSize = true;
      this.labelWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWeapon.Location = new System.Drawing.Point(10, 301);
      this.labelWeapon.Name = "labelWeapon";
      this.labelWeapon.Size = new System.Drawing.Size(92, 25);
      this.labelWeapon.TabIndex = 5;
      this.labelWeapon.Text = "Weapon";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(104, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 96);
      this.label2.TabIndex = 6;
      this.label2.Text = "Equipped Gear";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBoxArmor
      // 
      this.pictureBoxArmor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArmor.BackgroundImage")));
      this.pictureBoxArmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxArmor.InitialImage = null;
      this.pictureBoxArmor.Location = new System.Drawing.Point(109, 134);
      this.pictureBoxArmor.Name = "pictureBoxArmor";
      this.pictureBoxArmor.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxArmor.TabIndex = 7;
      this.pictureBoxArmor.TabStop = false;
      // 
      // pictureBoxWep
      // 
      this.pictureBoxWep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWep.BackgroundImage")));
      this.pictureBoxWep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxWep.InitialImage = null;
      this.pictureBoxWep.Location = new System.Drawing.Point(109, 265);
      this.pictureBoxWep.Name = "pictureBoxWep";
      this.pictureBoxWep.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxWep.TabIndex = 8;
      this.pictureBoxWep.TabStop = false;
      // 
      // pictureBoxSwordEquip
      // 
      this.pictureBoxSwordEquip.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.swordInven;
      this.pictureBoxSwordEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxSwordEquip.InitialImage = null;
      this.pictureBoxSwordEquip.Location = new System.Drawing.Point(109, 265);
      this.pictureBoxSwordEquip.Name = "pictureBoxSwordEquip";
      this.pictureBoxSwordEquip.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxSwordEquip.TabIndex = 9;
      this.pictureBoxSwordEquip.TabStop = false;
      this.pictureBoxSwordEquip.Click += new System.EventHandler(this.PictureBoxSwordEquip_Click);
      // 
      // pictureBoxArmorEquip
      // 
      this.pictureBoxArmorEquip.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.armorInven;
      this.pictureBoxArmorEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxArmorEquip.InitialImage = null;
      this.pictureBoxArmorEquip.Location = new System.Drawing.Point(109, 134);
      this.pictureBoxArmorEquip.Name = "pictureBoxArmorEquip";
      this.pictureBoxArmorEquip.Size = new System.Drawing.Size(86, 98);
      this.pictureBoxArmorEquip.TabIndex = 10;
      this.pictureBoxArmorEquip.TabStop = false;
      this.pictureBoxArmorEquip.Click += new System.EventHandler(this.PictureBoxArmorEquip_Click);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(315, 34);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 96);
      this.label3.TabIndex = 11;
      this.label3.Text = "Stats";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblArmor
      // 
      this.lblArmor.BackColor = System.Drawing.Color.Transparent;
      this.lblArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblArmor.ForeColor = System.Drawing.Color.Black;
      this.lblArmor.Location = new System.Drawing.Point(328, 155);
      this.lblArmor.Name = "lblArmor";
      this.lblArmor.Size = new System.Drawing.Size(56, 31);
      this.lblArmor.TabIndex = 12;
      this.lblArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblStrength
      // 
      this.lblStrength.BackColor = System.Drawing.Color.Transparent;
      this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStrength.ForeColor = System.Drawing.Color.Black;
      this.lblStrength.Location = new System.Drawing.Point(328, 306);
      this.lblStrength.Name = "lblStrength";
      this.lblStrength.Size = new System.Drawing.Size(56, 31);
      this.lblStrength.TabIndex = 13;
      this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(242, 311);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 24);
      this.label5.TabIndex = 14;
      this.label5.Text = "Strength";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(260, 160);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(62, 24);
      this.label6.TabIndex = 15;
      this.label6.Text = "Armor";
      // 
      // FrmInventory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblStrength);
      this.Controls.Add(this.lblArmor);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pictureBoxArmorEquip);
      this.Controls.Add(this.pictureBoxSwordEquip);
      this.Controls.Add(this.pictureBoxWep);
      this.Controls.Add(this.pictureBoxArmor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.labelWeapon);
      this.Controls.Add(this.labelArmor);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listViewInventory);
      this.Name = "FrmInventory";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwordEquip)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorEquip)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listViewInventory;
    private System.Windows.Forms.ColumnHeader colItemName;
    private System.Windows.Forms.ColumnHeader colType;
    private System.Windows.Forms.ColumnHeader colValue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelArmor;
    private System.Windows.Forms.Label labelWeapon;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBoxArmor;
    private System.Windows.Forms.PictureBox pictureBoxWep;
    private System.Windows.Forms.PictureBox pictureBoxSwordEquip;
    private System.Windows.Forms.PictureBox pictureBoxArmorEquip;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblArmor;
    private System.Windows.Forms.Label lblStrength;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}