using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968BFM1
{
    public partial class frmAddPart : Form
    {
        public frmAddPart()
        {
            InitializeComponent();
            txtAddPartID.Text = (Inventory.AllParts.Count + 1).ToString();
            txtAddPartID.ReadOnly = true;
        }

        private void radAddPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioChange.Text = "Machine ID";
            txtAddPartRadioChange.Text = "Machine ID";
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {

        }

        private void radAddPartOut_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioChange.Text = "Company";
            txtAddPartRadioChange.Text = "Company";
        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = Int32.Parse(txtAddPartMin.Text);
                maxStock = Int32.Parse(txtAddPartMax.Text);
                invInStock = Int32.Parse(txtAddPartInventory.Text);
                price = Decimal.Parse(txtAddPartPrice.Text);
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }



            string name = txtAddPartName.Text;
            price = Decimal.Parse(txtAddPartPrice.Text.Substring(1));
            minStock = Int32.Parse(txtAddPartMin.Text);
            maxStock = Int32.Parse(txtAddPartMax.Text);
            invInStock = Int32.Parse(txtAddPartInventory.Text);

            if (minStock > maxStock)
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum.");
                return;
            }
            if(invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Inventory cannont be greater or less than the Maximum and Minimum.");
            }

            if (radAddPartInHouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.AllParts.Count + 1), name, price, invInStock, minStock, maxStock, Int32.Parse(txtAddPartRadioChange.Text));

                Inventory.AddPart(inHouse);
            }
             else
             {
                 OutsourcedPart outsourced = new OutsourcedPart((Inventory.AllParts.Count + 1), name,price, invInStock, minStock, maxStock, txtAddPartRadioChange.Text);
                 Inventory.AddPart(outsourced);
             }
             
            
            this.Close();
        }

        private void txtAddPartName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
