namespace C968BFM1
{
    partial class frmModifyProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchModifyProd = new System.Windows.Forms.Button();
            this.txtSearchModifyProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModifyProdID = new System.Windows.Forms.TextBox();
            this.txtModifyProdName = new System.Windows.Forms.TextBox();
            this.txtModifyProdInventory = new System.Windows.Forms.TextBox();
            this.txtModifyProdPrice = new System.Windows.Forms.TextBox();
            this.txtModifyProdMin = new System.Windows.Forms.TextBox();
            this.txtModifyProdMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridModifyProductCan = new System.Windows.Forms.DataGridView();
            this.gridModifyProductAss = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // btnSearchModifyProd
            // 
            this.btnSearchModifyProd.Location = new System.Drawing.Point(809, 12);
            this.btnSearchModifyProd.Name = "btnSearchModifyProd";
            this.btnSearchModifyProd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchModifyProd.TabIndex = 1;
            this.btnSearchModifyProd.Text = "Search";
            this.btnSearchModifyProd.UseVisualStyleBackColor = true;
            // 
            // txtSearchModifyProd
            // 
            this.txtSearchModifyProd.Location = new System.Drawing.Point(915, 12);
            this.txtSearchModifyProd.Name = "txtSearchModifyProd";
            this.txtSearchModifyProd.Size = new System.Drawing.Size(234, 23);
            this.txtSearchModifyProd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "All candidate Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // txtModifyProdID
            // 
            this.txtModifyProdID.Location = new System.Drawing.Point(161, 151);
            this.txtModifyProdID.Name = "txtModifyProdID";
            this.txtModifyProdID.Size = new System.Drawing.Size(118, 23);
            this.txtModifyProdID.TabIndex = 7;
            this.txtModifyProdID.TextChanged += new System.EventHandler(this.txtModifyProdID_TextChanged);
            // 
            // txtModifyProdName
            // 
            this.txtModifyProdName.Location = new System.Drawing.Point(161, 189);
            this.txtModifyProdName.Name = "txtModifyProdName";
            this.txtModifyProdName.Size = new System.Drawing.Size(118, 23);
            this.txtModifyProdName.TabIndex = 8;
            // 
            // txtModifyProdInventory
            // 
            this.txtModifyProdInventory.Location = new System.Drawing.Point(161, 225);
            this.txtModifyProdInventory.Name = "txtModifyProdInventory";
            this.txtModifyProdInventory.Size = new System.Drawing.Size(118, 23);
            this.txtModifyProdInventory.TabIndex = 9;
            // 
            // txtModifyProdPrice
            // 
            this.txtModifyProdPrice.Location = new System.Drawing.Point(161, 266);
            this.txtModifyProdPrice.Name = "txtModifyProdPrice";
            this.txtModifyProdPrice.Size = new System.Drawing.Size(118, 23);
            this.txtModifyProdPrice.TabIndex = 10;
            // 
            // txtModifyProdMin
            // 
            this.txtModifyProdMin.Location = new System.Drawing.Point(246, 315);
            this.txtModifyProdMin.Name = "txtModifyProdMin";
            this.txtModifyProdMin.Size = new System.Drawing.Size(83, 23);
            this.txtModifyProdMin.TabIndex = 11;
            // 
            // txtModifyProdMax
            // 
            this.txtModifyProdMax.Location = new System.Drawing.Point(124, 315);
            this.txtModifyProdMax.Name = "txtModifyProdMax";
            this.txtModifyProdMax.Size = new System.Drawing.Size(82, 23);
            this.txtModifyProdMax.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Iventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Min";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(1049, 248);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddProd.TabIndex = 19;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1049, 489);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1049, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(957, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridModifyProductCan
            // 
            this.gridModifyProductCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModifyProductCan.Location = new System.Drawing.Point(500, 70);
            this.gridModifyProductCan.Name = "gridModifyProductCan";
            this.gridModifyProductCan.RowTemplate.Height = 25;
            this.gridModifyProductCan.Size = new System.Drawing.Size(649, 150);
            this.gridModifyProductCan.TabIndex = 23;
            // 
            // gridModifyProductAss
            // 
            this.gridModifyProductAss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModifyProductAss.Location = new System.Drawing.Point(500, 305);
            this.gridModifyProductAss.Name = "gridModifyProductAss";
            this.gridModifyProductAss.RowTemplate.Height = 25;
            this.gridModifyProductAss.Size = new System.Drawing.Size(649, 150);
            this.gridModifyProductAss.TabIndex = 24;
            // 
            // frmModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 605);
            this.Controls.Add(this.gridModifyProductAss);
            this.Controls.Add(this.gridModifyProductCan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModifyProdMax);
            this.Controls.Add(this.txtModifyProdMin);
            this.Controls.Add(this.txtModifyProdPrice);
            this.Controls.Add(this.txtModifyProdInventory);
            this.Controls.Add(this.txtModifyProdName);
            this.Controls.Add(this.txtModifyProdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchModifyProd);
            this.Controls.Add(this.btnSearchModifyProd);
            this.Controls.Add(this.label1);
            this.Name = "frmModifyProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSearchModifyProd;
        private TextBox txtSearchModifyProd;
        private Label label2;
        private Label label3;
        private TextBox txtModifyProdID;
        private TextBox txtModifyProdName;
        private TextBox txtModifyProdInventory;
        private TextBox txtModifyProdPrice;
        private TextBox txtModifyProdMin;
        private TextBox txtModifyProdMax;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAddProd;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private DataGridView gridModifyProductCan;
        private DataGridView gridModifyProductAss;
    }
}