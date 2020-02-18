using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Recipe
    {
        // check out UML for mem vars to add
        
        int amountOfLemons;
        int amountOfSugarCubes;
        int amountOfIceCubes;
        double pricePerCup;
        int cupsInRecipe;


        // constructor (SPAWNER)
        public Recipe()
        {

           
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 4;
            pricePerCup = .25;
            cupsInRecipe = 10;


        }
        public void ChangeRecipe(Player player)
        {
            
            Console.WriteLine("Your Recipe makes 10 cups");
            Console.WriteLine("Would you like to change your recipe?");
            Console.WriteLine("Yes or No");
           
            string ingriedientChoice = Console.ReadLine();

            switch (ingriedientChoice)
            {
                case "No":
                    Console.WriteLine("Choose from these options: Lemon, Sugar, Ice, Price per cup");
                    break;
                case "Lemons":
                    Console.WriteLine($"You have {player.inventory.lemons.Count} in your inventory.  How many would you like to add to your recipe?");
                    amountOfLemons = int.Parse(Console.ReadLine());
                    break;
                case "Ice":
                    Console.WriteLine($"You have {player.inventory.iceCubes.Count} in your inventory.  How many would you like to add to recipe?");
                    amountOfIceCubes = int.Parse(Console.ReadLine());
                    break;
                case "Sugar":
                    Console.WriteLine($"You have {player.inventory.sugarCubes.Count} in your inventory. How many would you like to add to recipe?");
                    amountOfSugarCubes = int.Parse(Console.ReadLine());
                    break;
                case "Price per cup":
                    Console.WriteLine($"Your price per cup is {pricePerCup} would you like to change the price?");
                    pricePerCup = double.Parse(Console.ReadLine());
                    break;
                 default:
                    Console.WriteLine("Please enter number to add.");
                    break;
                   
            }



        }



    }
}
