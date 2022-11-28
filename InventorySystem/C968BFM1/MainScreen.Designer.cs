namespace C968BFM1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gridMainParts = new System.Windows.Forms.DataGridView();
            this.PartIDMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventoryMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPriceMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMinMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMaxMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMainProducts = new System.Windows.Forms.DataGridView();
            this.ProductIDMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventoryMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMaxMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMinMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // gridMainParts
            // 
            this.gridMainParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMainParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartIDMain,
            this.PartNameMain,
            this.PartInventoryMain,
            this.PartPriceMain,
            this.PartMinMain,
            this.PartMaxMain});
            this.gridMainParts.Location = new System.Drawing.Point(12, 107);
            this.gridMainParts.Name = "gridMainParts";
            this.gridMainParts.RowTemplate.Height = 25;
            this.gridMainParts.Size = new System.Drawing.Size(643, 150);
            this.gridMainParts.TabIndex = 1;
            // 
            // PartIDMain
            // 
            this.PartIDMain.HeaderText = "Part ID";
            this.PartIDMain.Name = "PartIDMain";
            this.PartIDMain.Visible = false;
            // 
            // PartNameMain
            // 
            this.PartNameMain.HeaderText = "Part Name";
            this.PartNameMain.Name = "PartNameMain";
            this.PartNameMain.Visible = false;
            // 
            // PartInventoryMain
            // 
            this.PartInventoryMain.HeaderText = "Inventory";
            this.PartInventoryMain.Name = "PartInventoryMain";
            this.PartInventoryMain.Visible = false;
            // 
            // PartPriceMain
            // 
            this.PartPriceMain.HeaderText = "Price";
            this.PartPriceMain.Name = "PartPriceMain";
            this.PartPriceMain.Visible = false;
            // 
            // PartMinMain
            // 
            this.PartMinMain.HeaderText = "Min";
            this.PartMinMain.Name = "PartMinMain";
            this.PartMinMain.Visible = false;
            // 
            // PartMaxMain
            // 
            this.PartMaxMain.HeaderText = "Max";
            this.PartMaxMain.Name = "PartMaxMain";
            this.PartMaxMain.Visible = false;
            // 
            // gridMainProducts
            // 
            this.gridMainProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMainProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDMain,
            this.ProductNameMain,
            this.ProductInventoryMain,
            this.ProductPriceMain,
            this.ProductMaxMain,
            this.ProductMinMain});
            this.gridMainProducts.Location = new System.Drawing.Point(717, 107);
            this.gridMainProducts.Name = "gridMainProducts";
            this.gridMainProducts.RowTemplate.Height = 25;
            this.gridMainProducts.Size = new System.Drawing.Size(643, 150);
            this.gridMainProducts.TabIndex = 2;
            // 
            // ProductIDMain
            // 
            this.ProductIDMain.HeaderText = "Product ID";
            this.ProductIDMain.Name = "ProductIDMain";
            this.ProductIDMain.Visible = false;
            // 
            // ProductNameMain
            // 
            this.ProductNameMain.HeaderText = "Name";
            this.ProductNameMain.Name = "ProductNameMain";
            this.ProductNameMain.Visible = false;
            // 
            // ProductInventoryMain
            // 
            this.ProductInventoryMain.HeaderText = "Inventory";
            this.ProductInventoryMain.Name = "ProductInventoryMain";
            this.ProductInventoryMain.Visible = false;
            // 
            // ProductPriceMain
            // 
            this.ProductPriceMain.HeaderText = "Price";
            this.ProductPriceMain.Name = "ProductPriceMain";
            this.ProductPriceMain.Visible = false;
            // 
            // ProductMaxMain
            // 
            this.ProductMaxMain.HeaderText = "Max";
            this.ProductMaxMain.Name = "ProductMaxMain";
            this.ProductMaxMain.Visible = false;
            // 
            // ProductMinMain
            // 
            this.ProductMinMain.HeaderText = "Min";
            this.ProductMinMain.Name = "ProductMinMain";
            this.ProductMinMain.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(722, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(456, 74);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartSearch.TabIndex = 5;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(1159, 75);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductSearch.TabIndex = 6;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(555, 75);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(100, 23);
            this.txtPartSearch.TabIndex = 7;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(1260, 74);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(100, 23);
            this.txtProductSearch.TabIndex = 8;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(418, 273);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 44);
            this.btnAddPart.TabIndex = 9;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(499, 273);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(75, 44);
            this.btnModifyPart.TabIndex = 10;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(580, 273);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 44);
            this.btnDeletePart.TabIndex = 11;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1123, 273);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 44);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(1204, 273);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 44);
            this.btnModifyProduct.TabIndex = 13;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1285, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(1284, 273);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 450);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.txtPartSearch);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMainProducts);
            this.Controls.Add(this.gridMainParts);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Main Screen";
          
            ((System.ComponentModel.ISupportInitialize)(this.gridMainParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView gridMainParts;
        private DataGridView gridMainProducts;
        private Label label2;
        private Label label3;
        private Button btnPartSearch;
        private Button btnProductSearch;
        private TextBox txtPartSearch;
        private TextBox txtProductSearch;
        private Button btnAddPart;
        private Button btnModifyPart;
        private Button btnDeletePart;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnExit;
        private DataGridViewTextBoxColumn PartIDMain;
        private DataGridViewTextBoxColumn PartNameMain;
        private DataGridViewTextBoxColumn PartInventoryMain;
        private DataGridViewTextBoxColumn PartPriceMain;
        private DataGridViewTextBoxColumn PartMinMain;
        private DataGridViewTextBoxColumn PartMaxMain;
        private DataGridViewTextBoxColumn ProductIDMain;
        private DataGridViewTextBoxColumn ProductNameMain;
        private DataGridViewTextBoxColumn ProductInventoryMain;
        private DataGridViewTextBoxColumn ProductPriceMain;
        private DataGridViewTextBoxColumn ProductMaxMain;
        private DataGridViewTextBoxColumn ProductMinMain;
        private Button btnDeleteProduct;
    }
}