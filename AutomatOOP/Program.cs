using System;
using System.Collections.Generic;
using static System.Console;

namespace AutomatOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Vending Machine");

            WriteLine(" ");

            WriteLine("|  [1] item   |  [2] item |  [3] item |  [4] item |  [5] item |  [6] item | \n" +
                      "|  [7] item   |  [8] item |  [9] item | [10] item | [11] item | [12] item | \n" +
                      "| [13] item   | [14] item | [15] item | [16] item | [17] item | [18] item | \n");

            WriteLine(" ");

            WriteLine("Write the number of the product you want to purchase.");
            string product = ReadLine();
            Write("Product: " + product);

            ReadKey();

        }
    }
}
