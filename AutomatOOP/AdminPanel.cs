using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AutomatOOP
{
    class AdminPanel
    {
        public void Start()
        {
            Title = "AdminPanel"!;
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"" + "\n";
          

            string[] options = { "Add item", "Delete item", "Change item price", "Back"  };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    RunSecondChoice();
                    break;
                case 2:
                    RunThirdChoice();
                    break;
                case 3:
                    RunFourChoice();
                    break;
            }
        }

        private void RunFirstChoice()
        {
            WriteLine("Add an item");
            string name = ReadLine();
            Write("Name: " + name);
            double price = Convert.ToInt32(ReadLine());
            Write("Price: " + price);

            var creatingItem = new ProductData(name, price);
            creatingItem.products.Add(name);
        }
        private void RunSecondChoice()
        {
            WriteLine("Delete an item");
            string name = ReadLine();
            Write("Name: " + name);

            var creatingItem = new ProductData();
            creatingItem.products.Add();
        }
        private void RunThirdChoice()
        {

        }
        private void RunFourChoice()
        {

        }

    }
}
