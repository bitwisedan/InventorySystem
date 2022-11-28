using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace C968BFM1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            FrmMainLoad();
        }

        public void FrmMainLoad()
        {
            // Add dummy data from Inventory Class
            Inventory.PopulateDummyLists();

            //Part data in left table
            var partsDemo = new BindingSource();
            partsDemo.DataSource = Inventory.AllParts;
            gridMainParts.DataSource = partsDemo;

            gridMainParts.Columns["PartIDMain"].HeaderText = "Part ID";
            gridMainParts.Columns["PartNameMain"].HeaderText = "Part Name";
            gridMainParts.Columns["PartInventoryMain"].HeaderText = "Inventory";
            gridMainParts.Columns["PartPriceMain"].HeaderText = "Price";
            gridMainParts.Columns["Min"].HeaderText = "Min";
            gridMainParts.Columns["Max"].HeaderText = "Max";

            // Product data in right table
            var productsDemo = new BindingSource();
            productsDemo.DataSource = Inventory.Products;
            gridMainProducts.DataSource = productsDemo;

            gridMainProducts.Columns["ProductIDMain"].HeaderText = "Product ID";
            gridMainProducts.Columns["ProductNameMain"].HeaderText = "Name";
            gridMainProducts.Columns["ProductInventoryMain"].HeaderText = "Inventory";
            gridMainProducts.Columns["ProductPriceMain"].HeaderText = "Price";
            gridMainProducts.Columns["ProductMinMain"].HeaderText = "Min";
            gridMainProducts.Columns["ProductMaxMain"].HeaderText = "Max";
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            new frmAddPart().ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (gridMainParts.CurrentRow.DataBoundItem.GetType() == typeof(InHousePart))
            {
                InHousePart partIn = (InHousePart)gridMainParts.CurrentRow.DataBoundItem;
                new frmModifyPart(partIn).ShowDialog();
            }
            else
            {
                OutsourcedPart partOut = (OutsourcedPart)gridMainParts.CurrentRow.DataBoundItem;
                new frmModifyPart(partOut).ShowDialog();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product productSelected = (Product)gridMainProducts.CurrentRow.DataBoundItem;
            new frmAddProduct().ShowDialog();

        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in gridMainParts.SelectedRows)
                {
                    gridMainParts.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
            

        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            Product productSelected = (Product)gridMainProducts.CurrentRow.DataBoundItem;
            new frmModifyProduct(productSelected).ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            
            Product product = (Product)gridMainProducts.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a Product with a part assigned to it.");
                return;
            }
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in gridMainProducts.SelectedRows)
                {
                    gridMainProducts.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtPartSearch.Text) < 1)
                {
                    MessageBox.Show("Please enter a positive number. ");
                    return;
                }


                Part matchingPart = Inventory.LookupPart(Int32.Parse(txtPartSearch.Text));

                foreach (DataGridViewRow row in gridMainParts.Rows)
                {
                    Part part = (Part)row.DataBoundItem;

                    if (part.PartID == matchingPart.PartID)
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Could not find part.");
                return;
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Decimal.Parse(txtProductSearch.Text) < 1)
                {
                    return;
                }

                Product matchingPart = Inventory.LookupProduct(Int32.Parse(txtProductSearch.Text));

                foreach (DataGridViewRow row in gridMainProducts.Rows)
                {
                    Product product = (Product)row.DataBoundItem;

                    if (product.ProductID == matchingPart.ProductID)
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find product.");
                return;
            }
            
        }
    }
}

