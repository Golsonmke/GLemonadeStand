using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        public static string name;
        public static string Name { get { return name;  } set { name = value; } }
        public static void setName()
        {
            Console.WriteLine("What would you like to call your Lemonade Stand?");
            name = Console.ReadLine();
        }
        public static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to {name} Lemonade Stand!");
        }
    }
}
