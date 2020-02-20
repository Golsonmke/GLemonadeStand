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
        
       public int amountOfLemons;
       public int amountOfSugarCubes;
       public int amountOfIceCubes;
       public double pricePerCup;
       public int cupsInRecipe;


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
            
            string ingriedientChoice = Console.ReadLine();

            switch (ingriedientChoice)
            {
                

                case "Lemons":
                case "lemons":
                case "Lemon":
                case "lemon":
                    Console.WriteLine($"You have {player.inventory.lemons.Count} in your inventory.  How many would you like to add to your recipe?");
                    amountOfLemons = int.Parse(Console.ReadLine());
                    break;
                case "Ice":
                case "ice":
                    Console.WriteLine($"You have {player.inventory.iceCubes.Count} in your inventory.  How many would you like to add to recipe?");
                    amountOfIceCubes = int.Parse(Console.ReadLine());
                    break;
                case "Sugar":
                case "sugar":
                    Console.WriteLine($"You have {player.inventory.sugarCubes.Count} in your inventory. How many would you like to add to recipe?");
                    amountOfSugarCubes = int.Parse(Console.ReadLine());
                    break;
                case "Price per cup":
                case "price per cup":
                    Console.WriteLine($"Your price per cup is {pricePerCup} would you like to change the price?");
                    pricePerCup = double.Parse(Console.ReadLine());
                    break;
                 default:
                    Console.WriteLine("Please enter number to add.");
                    break;
                   
            }



        }
        public void SubtractLemonsFromInventory(Inventory inventory)
        {
            for (int i = 4; i < amountOfLemons; i--)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Remove(lemon);
            }
        }

        public void SubtractSugarCubesFromInventory(Inventory inventory)
        {

            for (int i = 4; i < amountOfSugarCubes; i--)
            {
                SugarCube sugarCube = new SugarCube();
                inventory.sugarCubes.Remove(sugarCube);
            }
        }

        public void SubtractIceCubesFromInventory(Inventory inventory)
        {
            for (int i = 4; i < amountOfIceCubes; i--)
            {
                IceCube iceCube = new IceCube();
                inventory.iceCubes.Remove(iceCube);
            }
        }

        public void SubtractCupsFromInventory(Inventory inventory)
        {
            for (int i = 10; i < cupsInRecipe; i--)
            {
                Cup cup = new Cup();
                inventory.cups.Remove(cup);
            }


        }


    }
}
