namespace C968BFM1
{
    partial class frmAddPart
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
            this.radAddPartInHouse = new System.Windows.Forms.RadioButton();
            this.radAddPartOut = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPartID = new System.Windows.Forms.TextBox();
            this.txtAddPartName = new System.Windows.Forms.TextBox();
            this.txtAddPartInventory = new System.Windows.Forms.TextBox();
            this.txtAddPartPrice = new System.Windows.Forms.TextBox();
            this.txtAddPartMax = new System.Windows.Forms.TextBox();
            this.txtAddPartMin = new System.Windows.Forms.TextBox();
            this.txtAddPartRadioChange = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblRadioChange = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radAddPartInHouse
            // 
            this.radAddPartInHouse.AutoSize = true;
            this.radAddPartInHouse.Location = new System.Drawing.Point(113, 12);
            this.radAddPartInHouse.Name = "radAddPartInHouse";
            this.radAddPartInHouse.Size = new System.Drawing.Size(74, 19);
            this.radAddPartInHouse.TabIndex = 0;
            this.radAddPartInHouse.TabStop = true;
            this.radAddPartInHouse.Text = "In-House";
            this.radAddPartInHouse.UseVisualStyleBackColor = true;
            this.radAddPartInHouse.CheckedChanged += new System.EventHandler(this.radAddPartInHouse_CheckedChanged);
            // 
            // radAddPartOut
            // 
            this.radAddPartOut.AutoSize = true;
            this.radAddPartOut.Location = new System.Drawing.Point(208, 12);
            this.radAddPartOut.Name = "radAddPartOut";
            this.radAddPartOut.Size = new System.Drawing.Size(87, 19);
            this.radAddPartOut.TabIndex = 1;
            this.radAddPartOut.TabStop = true;
            this.radAddPartOut.Text = "Outsourced";
            this.radAddPartOut.UseVisualStyleBackColor = true;
            this.radAddPartOut.CheckedChanged += new System.EventHandler(this.radAddPartOut_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Part";
            // 
            // txtAddPartID
            // 
            this.txtAddPartID.Location = new System.Drawing.Point(148, 62);
            this.txtAddPartID.Name = "txtAddPartID";
            this.txtAddPartID.Size = new System.Drawing.Size(122, 23);
            this.txtAddPartID.TabIndex = 3;
            // 
            // txtAddPartName
            // 
            this.txtAddPartName.Location = new System.Drawing.Point(148, 92);
            this.txtAddPartName.Name = "txtAddPartName";
            this.txtAddPartName.Size = new System.Drawing.Size(122, 23);
            this.txtAddPartName.TabIndex = 4;
            this.txtAddPartName.TextChanged += new System.EventHandler(this.txtAddPartName_TextChanged);
            // 
            // txtAddPartInventory
            // 
            this.txtAddPartInventory.Location = new System.Drawing.Point(148, 125);
            this.txtAddPartInventory.Name = "txtAddPartInventory";
            this.txtAddPartInventory.Size = new System.Drawing.Size(122, 23);
            this.txtAddPartInventory.TabIndex = 5;
            // 
            // txtAddPartPrice
            // 
            this.txtAddPartPrice.Location = new System.Drawing.Point(148, 157);
            this.txtAddPartPrice.Name = "txtAddPartPrice";
            this.txtAddPartPrice.Size = new System.Drawing.Size(122, 23);
            this.txtAddPartPrice.TabIndex = 6;
            // 
            // txtAddPartMax
            // 
            this.txtAddPartMax.Location = new System.Drawing.Point(148, 196);
            this.txtAddPartMax.Name = "txtAddPartMax";
            this.txtAddPartMax.Size = new System.Drawing.Size(63, 23);
            this.txtAddPartMax.TabIndex = 8;
            // 
            // txtAddPartMin
            // 
            this.txtAddPartMin.Location = new System.Drawing.Point(276, 196);
            this.txtAddPartMin.Name = "txtAddPartMin";
            this.txtAddPartMin.Size = new System.Drawing.Size(63, 23);
            this.txtAddPartMin.TabIndex = 9;
            // 
            // txtAddPartRadioChange
            // 
            this.txtAddPartRadioChange.Location = new System.Drawing.Point(148, 233);
            this.txtAddPartRadioChange.Name = "txtAddPartRadioChange";
            this.txtAddPartRadioChange.Size = new System.Drawing.Size(122, 23);
            this.txtAddPartRadioChange.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(121, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(82, 128);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(57, 15);
            this.lblInventory.TabIndex = 13;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(68, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 15);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price  / Cost";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(109, 199);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 15);
            this.lblMax.TabIndex = 16;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(242, 199);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 15);
            this.lblMin.TabIndex = 17;
            this.lblMin.Text = "Min";
            // 
            // lblRadioChange
            // 
            this.lblRadioChange.AutoSize = true;
            this.lblRadioChange.Location = new System.Drawing.Point(72, 236);
            this.lblRadioChange.Name = "lblRadioChange";
            this.lblRadioChange.Size = new System.Drawing.Size(67, 15);
            this.lblRadioChange.TabIndex = 18;
            this.lblRadioChange.Text = "Machine ID";
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Location = new System.Drawing.Point(173, 286);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(75, 37);
            this.btnAddPartSave.TabIndex = 21;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.btnAddPartSave_Click);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.Location = new System.Drawing.Point(264, 287);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(75, 34);
            this.btnAddPartCancel.TabIndex = 22;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.btnAddPartCancel_Click);
            // 
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 349);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.lblRadioChange);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtAddPartRadioChange);
            this.Controls.Add(this.txtAddPartMin);
            this.Controls.Add(this.txtAddPartMax);
            this.Controls.Add(this.txtAddPartPrice);
            this.Controls.Add(this.txtAddPartInventory);
            this.Controls.Add(this.txtAddPartName);
            this.Controls.Add(this.txtAddPartID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radAddPartOut);
            this.Controls.Add(this.radAddPartInHouse);
            this.Name = "frmAddPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radAddPartInHouse;
        private RadioButton radAddPartOut;
        private Label label1;
        private TextBox txtAddPartID;
        private TextBox txtAddPartName;
        private TextBox txtAddPartInventory;
        private TextBox txtAddPartPrice;
        private TextBox txtAddPartMax;
        private TextBox txtAddPartMin;
        private TextBox txtAddPartRadioChange;
        private Label lblID;
        private Label lblName;
        private Label lblInventory;
        private Label lblPrice;
        private Label lblMax;
        private Label lblMin;
        private Label lblRadioChange;
        private Button btnAddPartSave;
        private Button btnAddPartCancel;
    }
}