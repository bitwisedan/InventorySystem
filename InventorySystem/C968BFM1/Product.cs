using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968BFM1
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public Product() { }
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool result = false;

            foreach(Part part in AssociatedParts) 
            { 
                if(part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public Part LookupAsociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if(part.PartID==partID)
                {
                    return part;
                }
            }
            InHousePart empty = new InHousePart();
            return empty;
        }
    }
}
