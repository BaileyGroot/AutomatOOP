using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AutomatOOP
{
    class MainMenu
    {

        public void Start()
        {
            Title = "Vending Machine";
            RunMainMenu();
        }

     private void RunMainMenu()
        {
            string[] options = { "1. Choose Product", "2. Refund", "3. AdminPanel", "4. Exit Menu"};
            MenuCode mainMenu = new MenuCode(options);
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
                    RunThirdChoice();
                    break;

            }
      
        }
        private void RunFirstChoice()
        {
            Clear();
            WriteLine("Hello there! You can choose the product you want to purchase by wring their (id) which is located down below the price.");
            Write("Id: ");
            int id = Convert.ToInt32(ReadLine());
            Product product = new Product();

            foreach (ProductConstructor i in product.Products)
            {
                if (id == i.Id)
                {
                    WriteLine("Name " + i.Name + "Price: " + i.Price);
                    ReadKey(true);
                }
                else
                {
                    WriteLine("Couldn't locate the id!");
                    ReadKey(true);
                }
            }

            WriteLine(product);
            ReadKey(true);

            WriteLine("Return to Menu?");
            Write("Answer(Yes/No): ");
            var answer = ReadLine();

            if (answer == "No")
            {
            RunMainMenu();
            }
            else if (answer == "No")
            {
                ExitMenu();
            }
            else
            {
                WriteLine("Ivalid Response returning to Menu.");
                ReadKey(true);
                RunMainMenu();
            }

            ReadKey(true);
        }
        private void RunSecondChoice()
        {

        }
        private void RunThirdChoice()
        {

        }
        private void ExitMenu()
        {
            Environment.Exit(0);
        }
    }
}
