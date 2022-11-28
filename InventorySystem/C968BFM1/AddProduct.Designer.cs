namespace C968BFM1
{
    partial class frmAddProduct
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
            this.btnSearchAddProd = new System.Windows.Forms.Button();
            this.txtSearchAddProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddProdID = new System.Windows.Forms.TextBox();
            this.txtAddProdName = new System.Windows.Forms.TextBox();
            this.txtAddProdInventory = new System.Windows.Forms.TextBox();
            this.txtAddProdPrice = new System.Windows.Forms.TextBox();
            this.txtAddProdMin = new System.Windows.Forms.TextBox();
            this.txtAddProdMax = new System.Windows.Forms.TextBox();
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
            this.gridAddProdCan = new System.Windows.Forms.DataGridView();
            this.gridAddProdAss = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddProdCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddProdAss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // btnSearchAddProd
            // 
            this.btnSearchAddProd.Location = new System.Drawing.Point(809, 12);
            this.btnSearchAddProd.Name = "btnSearchAddProd";
            this.btnSearchAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAddProd.TabIndex = 1;
            this.btnSearchAddProd.Text = "Search";
            this.btnSearchAddProd.UseVisualStyleBackColor = true;
            this.btnSearchAddProd.Click += new System.EventHandler(this.btnSearchAddProd_Click);
            // 
            // txtSearchAddProd
            // 
            this.txtSearchAddProd.Location = new System.Drawing.Point(915, 12);
            this.txtSearchAddProd.Name = "txtSearchAddProd";
            this.txtSearchAddProd.Size = new System.Drawing.Size(234, 23);
            this.txtSearchAddProd.TabIndex = 2;
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAddProdID
            // 
            this.txtAddProdID.Location = new System.Drawing.Point(161, 151);
            this.txtAddProdID.Name = "txtAddProdID";
            this.txtAddProdID.Size = new System.Drawing.Size(118, 23);
            this.txtAddProdID.TabIndex = 7;
            // 
            // txtAddProdName
            // 
            this.txtAddProdName.Location = new System.Drawing.Point(161, 189);
            this.txtAddProdName.Name = "txtAddProdName";
            this.txtAddProdName.Size = new System.Drawing.Size(118, 23);
            this.txtAddProdName.TabIndex = 8;
            // 
            // txtAddProdInventory
            // 
            this.txtAddProdInventory.Location = new System.Drawing.Point(161, 225);
            this.txtAddProdInventory.Name = "txtAddProdInventory";
            this.txtAddProdInventory.Size = new System.Drawing.Size(118, 23);
            this.txtAddProdInventory.TabIndex = 9;
            // 
            // txtAddProdPrice
            // 
            this.txtAddProdPrice.Location = new System.Drawing.Point(161, 266);
            this.txtAddProdPrice.Name = "txtAddProdPrice";
            this.txtAddProdPrice.Size = new System.Drawing.Size(118, 23);
            this.txtAddProdPrice.TabIndex = 10;
            // 
            // txtAddProdMin
            // 
            this.txtAddProdMin.Location = new System.Drawing.Point(246, 315);
            this.txtAddProdMin.Name = "txtAddProdMin";
            this.txtAddProdMin.Size = new System.Drawing.Size(83, 23);
            this.txtAddProdMin.TabIndex = 11;
            // 
            // txtAddProdMax
            // 
            this.txtAddProdMax.Location = new System.Drawing.Point(124, 315);
            this.txtAddProdMax.Name = "txtAddProdMax";
            this.txtAddProdMax.Size = new System.Drawing.Size(82, 23);
            this.txtAddProdMax.TabIndex = 12;
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
            // gridAddProdCan
            // 
            this.gridAddProdCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddProdCan.Location = new System.Drawing.Point(500, 70);
            this.gridAddProdCan.Name = "gridAddProdCan";
            this.gridAddProdCan.RowTemplate.Height = 25;
            this.gridAddProdCan.Size = new System.Drawing.Size(649, 150);
            this.gridAddProdCan.TabIndex = 23;
            // 
            // gridAddProdAss
            // 
            this.gridAddProdAss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddProdAss.Location = new System.Drawing.Point(500, 305);
            this.gridAddProdAss.Name = "gridAddProdAss";
            this.gridAddProdAss.RowTemplate.Height = 25;
            this.gridAddProdAss.Size = new System.Drawing.Size(649, 150);
            this.gridAddProdAss.TabIndex = 24;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 605);
            this.Controls.Add(this.gridAddProdAss);
            this.Controls.Add(this.gridAddProdCan);
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
            this.Controls.Add(this.txtAddProdMax);
            this.Controls.Add(this.txtAddProdMin);
            this.Controls.Add(this.txtAddProdPrice);
            this.Controls.Add(this.txtAddProdInventory);
            this.Controls.Add(this.txtAddProdName);
            this.Controls.Add(this.txtAddProdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchAddProd);
            this.Controls.Add(this.btnSearchAddProd);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.gridAddProdCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddProdAss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSearchAddProd;
        private TextBox txtSearchAddProd;
        private Label label2;
        private Label label3;
        private TextBox txtAddProdID;
        private TextBox txtAddProdName;
        private TextBox txtAddProdInventory;
        private TextBox txtAddProdPrice;
        private TextBox txtAddProdMin;
        private TextBox txtAddProdMax;
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
        private DataGridView gridAddProdCan;
        private DataGridView gridAddProdAss;
    }
}