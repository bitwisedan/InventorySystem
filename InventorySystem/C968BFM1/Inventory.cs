using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C968BFM1
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void PopulateDummyLists()
        {
            Product dummyProd1 = new Product(1, "Product 1", 10.00m, 10, 20, 5);
            Product dummyProd2 = new Product(2, "Product 2", 11.00m, 10, 25, 5);
            Product dummyProd3 = new Product(3, "Product 3", 12, 25, 10, 5);
            Product dummyProd4 = new Product(4, "Product 4", 13m, 25, 10, 5);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

            Part dummyPart1 = new InHousePart(1, "Part 1", 15.00m, 30, 10, 100, 111);
            Part dummyPart2 = new InHousePart(2, "Part 2", 12.00m, 25, 10, 100, 222);
            Part dummyPart3 = new OutsourcedPart(3, "Part 3", 15.00m, 10, 10, 100, "Acme Co");
            Part dummyPart4 = new OutsourcedPart(4, "Part 4", 12.00m, 25, 10, 100, "Acme Co");
            

            AllParts.Add(dummyPart1);
            AllParts.Add(dummyPart2);
            AllParts.Add(dummyPart3);
            AllParts.Add(dummyPart4);
           

            dummyProd1.AssociatedParts.Add(dummyPart1);
            dummyProd1.AssociatedParts.Add(dummyPart2);
            dummyProd2.AssociatedParts.Add(dummyPart3);
            dummyProd2.AssociatedParts.Add(dummyPart4);
            dummyProd3.AssociatedParts.Add(dummyPart4);
            dummyProd3.AssociatedParts.Add(dummyPart3);
            dummyProd4.AssociatedParts.Add(dummyPart2);
            dummyProd4.AssociatedParts.Add(dummyPart1);
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public bool RemoveProduct(int productID)
        {
            bool result = false;
            foreach (Product product in Products)
            {
                if (productID == product.ProductID)
                {
                    Products.Remove(product);
                    return result = true;
                }
                else
                {
                    MessageBox.Show("Removal failure.");
                    return false;
                }
            }
            return result;
        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }
        public static void UpdateProduct(int productID, Product product)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = product.Name;
                    currentProduct.Price = product.Price;
                    currentProduct.InStock = product.InStock;
                    currentProduct.Min = product.Min;
                    currentProduct.Max = product.Max;
                    currentProduct.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        
        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = new InHousePart();
            return emptyPart;
        }

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }
    }
}










