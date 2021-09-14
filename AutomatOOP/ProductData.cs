using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOOP
{
    class ProductData
    {

        string item;
        double price;

        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public List<ProductData> products = new List<ProductData>();

        public ProductData(string item, double price)
        {
            Item = item;
            Price = price;
        }
        public ProductData()
        {
            
        }

    }
}
