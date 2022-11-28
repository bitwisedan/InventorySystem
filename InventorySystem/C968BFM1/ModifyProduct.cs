using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968BFM1
{
    public partial class frmModifyProduct : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
    

        public frmModifyProduct(Product product)
        {
            InitializeComponent();
            FrmModifyProductLoad(product);
        }

        public void FrmModifyProductLoad(Product selectedProduct)
        {
            txtModifyProdID.Text = selectedProduct.ProductID.ToString();
            txtModifyProdID.ReadOnly = true;
            txtModifyProdName.Text = selectedProduct.Name.ToString();
            txtModifyProdPrice.Text = selectedProduct.Price.ToString();
            txtModifyProdInventory.Text = selectedProduct.InStock.ToString();
            txtModifyProdMin.Text = selectedProduct.Min.ToString();
            txtModifyProdMax.Text = selectedProduct.Max.ToString();

            var sourceOne = new BindingSource();
            sourceOne.DataSource = Inventory.AllParts;
            gridModifyProductCan.DataSource = sourceOne;
            gridModifyProductCan.Columns["PartID"].HeaderText = "Part ID";
            gridModifyProductCan.Columns["Name"].HeaderText= "Name";
            gridModifyProductCan.Columns["Price"].HeaderText = "Price / Unit";
            gridModifyProductCan.Columns["InStock"].HeaderText = "Inventory";
            gridModifyProductCan.Columns["Min"].HeaderText = "Min";
            gridModifyProductCan.Columns["Max"].HeaderText = "Max";

            foreach(Part part in selectedProduct.AssociatedParts)
            {
                partsToAdd.Add(part);   
            }

            var sourceTwo = new BindingSource();
            sourceTwo.DataSource = partsToAdd;
            gridModifyProductAss.DataSource = sourceTwo;
            gridModifyProductAss.Columns["PartID"].HeaderText = "Part ID";
            gridModifyProductAss.Columns["Name"].HeaderText = "Name";
            gridModifyProductAss.Columns["Price"].HeaderText = "Price / Unit";
            gridModifyProductAss.Columns["InStock"].HeaderText = "Inventory";
            gridModifyProductAss.Columns["Min"].HeaderText = "Min";
            gridModifyProductAss.Columns["Max"].HeaderText = "Max";
        }

        private void txtModifyProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Part currentPart = (Part)gridModifyProductAss.CurrentRow.DataBoundItem;

            int lookupID = Int32.Parse(this.txtModifyProdID.Text);
            Product currentProduct = Inventory.LookupProduct(lookupID);
            currentProduct.RemoveAssociatedPart(currentPart.PartID);
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in gridModifyProductAss.SelectedRows)
                {
                    gridModifyProductAss.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)gridModifyProductCan.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;

            try
            {
                min = Int32.Parse(txtModifyProdMin.Text);
                max = Int32.Parse(txtModifyProdMax.Text);
                inventory =Int32.Parse(txtModifyProdInventory.Text);
                price = Decimal.Parse(txtModifyProdPrice.Text.Substring(1));
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = Int32.Parse(txtModifyProdID.Text);
            string name = txtModifyProdName.Text;
            inventory = Int32.Parse(txtModifyProdInventory.Text);
            price = Decimal.Parse(txtModifyProdPrice.Text.Substring(1));
            min = Int32.Parse(txtModifyProdMin.Text);
            max = Int32.Parse(txtModifyProdMax.Text);

            if (min > max)
            {
                MessageBox.Show("Minimum cannot be greater than Maximum");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Inventory cannont be greater than the Maximum or lesser than the Minimum.");
            }

            Product updatedProduct = new Product(id,name,price, inventory,min,max);

            foreach(Part newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }


            int prodID = int.Parse(txtModifyProdID.Text);
            Inventory.UpdateProduct(prodID, updatedProduct);
            this.Close();
            frmMain main = new frmMain();
           
            
        }
    }
}
