using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968BFM1
{
    public  class InHousePart : Part
    {
        private int machineID;

        public int MachineID { get; set; }
        //Default for search failure
        public InHousePart(){}
        public InHousePart(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID= partID;
            Name = name;
            InStock= inStock;
            Price = price.ToString();   
            Max = max;
            Min = min;
        }

        public InHousePart(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }

    }
}
