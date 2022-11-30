using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968BFM1
{
    public partial class frmAddProduct : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        public frmAddProduct()
        {
            InitializeComponent();
            FrmAddProductLoad();
        }

        public void FrmAddProductLoad()
        {
            txtAddProdID.Text = (Inventory.AllParts.Count + 1).ToString();
            txtAddProdID.ReadOnly = true;
            var sourceOne = new BindingSource();
            sourceOne.DataSource = Inventory.AllParts;
            gridAddProdCan.DataSource = sourceOne;
            gridAddProdCan.Columns["PartID"].HeaderText = "Part ID";
            gridAddProdCan.Columns["Name"].HeaderText = "Name";
            gridAddProdCan.Columns["Price"].HeaderText = "Price per Unit";
            gridAddProdCan.Columns["InStock"].HeaderText = "Inventory";
            gridAddProdCan.Columns["Min"].HeaderText = "Min";
            gridAddProdCan.Columns["Max"].HeaderText = "Max";

            var sourceTwo = new BindingSource();
            sourceTwo.DataSource = partsToAdd;
            gridAddProdAss.DataSource = sourceTwo;
            gridAddProdAss.Columns["PartID"].HeaderText = "Part ID";
            gridAddProdAss.Columns["Name"].HeaderText = "Name";
            gridAddProdAss.Columns["Price"].HeaderText = "Price per Unit";
            gridAddProdAss.Columns["InStock"].HeaderText = "Inventory";
            gridAddProdAss.Columns["Min"].HeaderText = "Min";
            gridAddProdAss.Columns["Max"].HeaderText = "Max";
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)gridAddProdCan.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridAddProdAss.Rows)
            {
                gridAddProdAss.Rows.RemoveAt(row.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;

            try
            {
                min = Int32.Parse(txtAddProdMin.Text);
                max = Int32.Parse(txtAddProdMax.Text);
                inventory = Int32.Parse(txtAddProdInventory.Text);
                price = Decimal.Parse(txtAddProdPrice.Text);
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max and Min fields must be numeric values.");
                return;
            }
           

            string name = txtAddProdName.Text;
            inventory = Int32.Parse(txtAddProdInventory.Text);
            price = Decimal.Parse(txtAddProdPrice.Text);
            min = Int32.Parse(txtAddProdMin.Text);
            max = Int32.Parse(txtAddProdMax.Text);

            if (min > max)
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum");
                return;
            }

            if (inventory > max || inventory  < min)
            {
                MessageBox.Show("Inventory cannont be greater or less than than the Maximum.");
            }

            Product productToAdd = new Product((Inventory.Products.Count + 1), name, price, inventory, min, max);
            Inventory.AddProduct(productToAdd);   

            foreach(Part part in partsToAdd)
            {
                productToAdd.AddAssociatedPart(part);
            }
            this.Close();
        }

        private void btnSearchAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                int search = Int32.Parse(txtSearchAddProd.Text);
                Part matchingPart = Inventory.LookupPart(search);

                foreach (DataGridViewRow row in gridAddProdCan.Rows)
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
            catch(Exception ex)
            {
                MessageBox.Show("Could not find part.");
            }
        }
    }
}
