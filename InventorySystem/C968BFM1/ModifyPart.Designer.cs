namespace C968BFM1
{
    partial class frmModifyPart
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
            this.radModifyPartInHouse = new System.Windows.Forms.RadioButton();
            this.radModifyPartOut = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifyPartID = new System.Windows.Forms.TextBox();
            this.txtModifyPartName = new System.Windows.Forms.TextBox();
            this.txtModifyPartInventory = new System.Windows.Forms.TextBox();
            this.txtModifyPartPrice = new System.Windows.Forms.TextBox();
            this.txtModifyPartMax = new System.Windows.Forms.TextBox();
            this.txtModifyPartMin = new System.Windows.Forms.TextBox();
            this.txtModifyPartRadioChange = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblRadioChange = new System.Windows.Forms.Label();
            this.btnModifyPartSave = new System.Windows.Forms.Button();
            this.btnModifyPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radModifyPartInHouse
            // 
            this.radModifyPartInHouse.AutoSize = true;
            this.radModifyPartInHouse.Location = new System.Drawing.Point(113, 12);
            this.radModifyPartInHouse.Name = "radModifyPartInHouse";
            this.radModifyPartInHouse.Size = new System.Drawing.Size(74, 19);
            this.radModifyPartInHouse.TabIndex = 0;
            this.radModifyPartInHouse.TabStop = true;
            this.radModifyPartInHouse.Text = "In-House";
            this.radModifyPartInHouse.UseVisualStyleBackColor = true;
            this.radModifyPartInHouse.CheckedChanged += new System.EventHandler(this.radModifyPartInHouse_CheckedChanged);
            // 
            // radModifyPartOut
            // 
            this.radModifyPartOut.AutoSize = true;
            this.radModifyPartOut.Location = new System.Drawing.Point(208, 12);
            this.radModifyPartOut.Name = "radModifyPartOut";
            this.radModifyPartOut.Size = new System.Drawing.Size(87, 19);
            this.radModifyPartOut.TabIndex = 1;
            this.radModifyPartOut.TabStop = true;
            this.radModifyPartOut.Text = "Outsourced";
            this.radModifyPartOut.UseVisualStyleBackColor = true;
            this.radModifyPartOut.CheckedChanged += new System.EventHandler(this.radModifyPartOut_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modify Part";
            // 
            // txtModifyPartID
            // 
            this.txtModifyPartID.Location = new System.Drawing.Point(148, 62);
            this.txtModifyPartID.Name = "txtModifyPartID";
            this.txtModifyPartID.Size = new System.Drawing.Size(122, 23);
            this.txtModifyPartID.TabIndex = 3;
            // 
            // txtModifyPartName
            // 
            this.txtModifyPartName.Location = new System.Drawing.Point(148, 92);
            this.txtModifyPartName.Name = "txtModifyPartName";
            this.txtModifyPartName.Size = new System.Drawing.Size(122, 23);
            this.txtModifyPartName.TabIndex = 4;
            // 
            // txtModifyPartInventory
            // 
            this.txtModifyPartInventory.Location = new System.Drawing.Point(148, 125);
            this.txtModifyPartInventory.Name = "txtModifyPartInventory";
            this.txtModifyPartInventory.Size = new System.Drawing.Size(122, 23);
            this.txtModifyPartInventory.TabIndex = 5;
            // 
            // txtModifyPartPrice
            // 
            this.txtModifyPartPrice.Location = new System.Drawing.Point(148, 157);
            this.txtModifyPartPrice.Name = "txtModifyPartPrice";
            this.txtModifyPartPrice.Size = new System.Drawing.Size(122, 23);
            this.txtModifyPartPrice.TabIndex = 6;
            // 
            // txtModifyPartMax
            // 
            this.txtModifyPartMax.Location = new System.Drawing.Point(148, 196);
            this.txtModifyPartMax.Name = "txtModifyPartMax";
            this.txtModifyPartMax.Size = new System.Drawing.Size(63, 23);
            this.txtModifyPartMax.TabIndex = 8;
            this.txtModifyPartMax.TextChanged += new System.EventHandler(this.txtModifyPartMax_TextChanged);
            // 
            // txtModifyPartMin
            // 
            this.txtModifyPartMin.Location = new System.Drawing.Point(276, 196);
            this.txtModifyPartMin.Name = "txtModifyPartMin";
            this.txtModifyPartMin.Size = new System.Drawing.Size(63, 23);
            this.txtModifyPartMin.TabIndex = 9;
            // 
            // txtModifyPartRadioChange
            // 
            this.txtModifyPartRadioChange.Location = new System.Drawing.Point(148, 233);
            this.txtModifyPartRadioChange.Name = "txtModifyPartRadioChange";
            this.txtModifyPartRadioChange.Size = new System.Drawing.Size(122, 23);
            this.txtModifyPartRadioChange.TabIndex = 10;
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
            // btnModifyPartSave
            // 
            this.btnModifyPartSave.Location = new System.Drawing.Point(173, 286);
            this.btnModifyPartSave.Name = "btnModifyPartSave";
            this.btnModifyPartSave.Size = new System.Drawing.Size(75, 37);
            this.btnModifyPartSave.TabIndex = 21;
            this.btnModifyPartSave.Text = "Save";
            this.btnModifyPartSave.UseVisualStyleBackColor = true;
            this.btnModifyPartSave.Click += new System.EventHandler(this.btnModifyPartSave_Click);
            // 
            // btnModifyPartCancel
            // 
            this.btnModifyPartCancel.Location = new System.Drawing.Point(264, 287);
            this.btnModifyPartCancel.Name = "btnModifyPartCancel";
            this.btnModifyPartCancel.Size = new System.Drawing.Size(75, 34);
            this.btnModifyPartCancel.TabIndex = 22;
            this.btnModifyPartCancel.Text = "Cancel";
            this.btnModifyPartCancel.UseVisualStyleBackColor = true;
            this.btnModifyPartCancel.Click += new System.EventHandler(this.btnModifyPartCancel_Click);
            // 
            // frmModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 349);
            this.Controls.Add(this.btnModifyPartCancel);
            this.Controls.Add(this.btnModifyPartSave);
            this.Controls.Add(this.lblRadioChange);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtModifyPartRadioChange);
            this.Controls.Add(this.txtModifyPartMin);
            this.Controls.Add(this.txtModifyPartMax);
            this.Controls.Add(this.txtModifyPartPrice);
            this.Controls.Add(this.txtModifyPartInventory);
            this.Controls.Add(this.txtModifyPartName);
            this.Controls.Add(this.txtModifyPartID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radModifyPartOut);
            this.Controls.Add(this.radModifyPartInHouse);
            this.Name = "frmModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.frmModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radModifyPartInHouse;
        private RadioButton radModifyPartOut;
        private Label label1;
        private TextBox txtModifyPartID;
        private TextBox txtModifyPartName;
        private TextBox txtModifyPartInventory;
        private TextBox txtModifyPartPrice;
        private TextBox txtModifyPartMax;
        private TextBox txtModifyPartMin;
        private TextBox txtModifyPartRadioChange;
        private Label lblID;
        private Label lblName;
        private Label lblInventory;
        private Label lblPrice;
        private Label lblMax;
        private Label lblMin;
        private Label lblRadioChange;
        private Button btnModifyPartSave;
        private Button btnModifyPartCancel;
    }
}