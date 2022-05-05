using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_1_LINQ1
{
    public class Invoice
    {
        private int quantityValue;
        private decimal priceValue;

        public int PartNumber { get; set; }

        public string PartDescription { get; set; }

        public Invoice(int part, string description, int count, decimal pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            quantityValue = count;
            Price = pricePerItem;
        }

        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if(value > 0)
                {
                    quantityValue = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0M)
                {
                    priceValue = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{PartNumber,-5}{PartDescription,-20}{Quantity,-5}{Price,6:C}";
        }
    }
}
