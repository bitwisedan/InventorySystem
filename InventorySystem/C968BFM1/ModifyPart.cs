using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968BFM1
{
    public partial class frmModifyPart : Form
    {
        public frmModifyPart(InHousePart partIn)
        {
            InitializeComponent();

            txtModifyPartID.Text = partIn.PartID.ToString();
            txtModifyPartID.ReadOnly= true;
            txtModifyPartName.Text = partIn.Name;
            txtModifyPartInventory.Text = partIn.InStock.ToString();
            txtModifyPartPrice.Text = partIn.Price.ToString();
            txtModifyPartMin.Text = partIn.Min.ToString();
            txtModifyPartMax.Text = partIn.Max.ToString();
            txtModifyPartRadioChange.Text = partIn.MachineID.ToString();

            radModifyPartInHouse.Checked = true;    
        }
        public frmModifyPart(OutsourcedPart partOut)
        {
            InitializeComponent();

            txtModifyPartID.Text = partOut.PartID.ToString();
            txtModifyPartName.Text = partOut.Name;
            txtModifyPartInventory.Text = partOut.InStock.ToString();
            txtModifyPartPrice.Text = partOut.Price.ToString();
            txtModifyPartMin.Text = partOut.Min.ToString();
            txtModifyPartMax.Text = partOut.Max.ToString();
            txtModifyPartRadioChange.Text = partOut.CompanyName;
            
            radModifyPartOut.Checked = true;
        }

            private void radModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioChange.Text = "Machine ID";
            
        }

        private void frmModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radModifyPartOut_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioChange.Text = "Company";
     
        }

        private void btnModifyPartSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = Int32.Parse(txtModifyPartMin.Text);
                maxStock = Int32.Parse(txtModifyPartMax.Text);
                invInStock = Int32.Parse(txtModifyPartInventory.Text);
                price = Decimal.Parse(txtModifyPartPrice.Text.Substring(1));
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = Int32.Parse(txtModifyPartID.Text);
            string name = txtModifyPartName.Text;
            price = Decimal.Parse(txtModifyPartPrice.Text.Substring(1));
            minStock = Int32.Parse(txtModifyPartMin.Text);
            maxStock = Int32.Parse(txtModifyPartMax.Text);
            invInStock = Int32.Parse(txtModifyPartInventory.Text);


            if (minStock > maxStock)
            {
                MessageBox.Show("Max must be greater than min.");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Inventory cannot be greater than the Maximum or less than the Minimum.");
                return;
            }

            if (radModifyPartInHouse.Checked)
            {
                InHousePart inPart = new InHousePart(id, name, price, invInStock,  minStock, maxStock, Int32.Parse(txtModifyPartRadioChange.Text));
                Inventory.UpdatePart(id, inPart);
                radModifyPartInHouse.Checked = true;
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, price, invInStock,  minStock, maxStock, txtModifyPartRadioChange.Text);
                Inventory.UpdatePart(id, outPart);
                radModifyPartOut.Checked = true;
            }
            Close();
           


        }

        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
