using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOOP
{
    class ProductConstructor
    {
        string author;
        string name;
        int price;
        int id;

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Price
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
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public ProductConstructor(string author, string name, int price, int id)
        {
            Author = author;
            Name = name;
            Price = price;
            Id = id;
        }

    }
}
