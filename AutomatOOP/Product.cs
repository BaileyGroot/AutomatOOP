using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatOOP
{
    class Product
    {
        List<ProductConstructor> products = new List<ProductConstructor>();
        public List<ProductConstructor> Products {
            get { return products; } }




        public void ProductList()
        {
        ProductConstructor CocaCola = new ProductConstructor("The Coca-Cola Company", "CocaCola", 25, 1);
            products.Add(CocaCola);
        ProductConstructor CocaColaZero = new ProductConstructor("The Coca-Cola Company", "CocaCola Zero", 25, 4);
            products.Add(CocaColaZero);
        ProductConstructor Pepsi = new ProductConstructor("PepsiCo", "Pepsi", 25, 2);
            products.Add(Pepsi);
        ProductConstructor PesiMax = new ProductConstructor("PepsiCo", "Pepsi Max", 25, 3);
            products.Add(PesiMax);
        ProductConstructor Fanta = new ProductConstructor("The Coca-Cola Company", "Fanta", 25, 4);
            products.Add(Fanta);
        ProductConstructor Sprite = new ProductConstructor("The Coca-Cola Company", "Sprite", 25, 5);
            products.Add(Sprite);
        ProductConstructor Twix = new ProductConstructor("Mars, inc.", "Twix", 15, 6);
            products.Add(Pepsi);
        ProductConstructor Snicker = new ProductConstructor("PepsiCo", "Snicker", 15, 7);
            products.Add(Snicker);
        }
        


    }
}
