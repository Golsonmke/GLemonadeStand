using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        // what
        // where
        // how

        public Player player;
        List<Day> days;
        public int currentDay;
        Store store;
       
      

        public double transactionAmount { get; private set; }

        public Game()
        {
           
            player = new Player();
            currentDay = 0;                          // Not sure I need all these?
            days = new List<Day>();
             store = new Store();
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("Lemonade Stand");
            Console.WriteLine("You have 7 days to make as much money as possible, and you've decided to open a lemonade stand!",
                "You'll have Complete control over your buisness, including pricing, quality control inventory control and purchasing supplies. ",
                "Buy you ingridients and start selling! ");
            Console.WriteLine();
            Console.WriteLine("The first thing you'll have to worry about is your recipe. At first, go with " +
                "the default recipe, but try to experiment a little bit and see if you can find " +
                "a better one. Make sure you buy enough of all your ingridients, or you " +
                "won't be able to sell!" );
            Console.WriteLine("You'll also have to deal with the weather, which will play a big part when " +
                "customers are deciding wether or not to buy your lemonade. Read the " +
                "weather report every day! When the weather drops, or the weather " +
                "turns bad (overcast, cloudy, rain) don't expect them to buy nearly as " +
                "much as they would on a hot, hazy day, so buy accordingly. Feelfree to " +
                "set your prices higher on those hot, muggy days too, as you'll make "  +
                "more profit, even if you sell a bit less lemonade");
            Console.WriteLine();
          
            
        }
        public void PurchaseInventory()
        {    
            DisplayItems();
            store.SellLemons(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
           
        }
        public void DisplayItems()
        {
            Console.WriteLine("Lemons: .05 ");
            Console.WriteLine("Sugar Cubes: .01 ");
            Console.WriteLine("Ice Cubes: .01");
            Console.WriteLine("Paper Cups: .25");
        }
        public void RunDay()
        {

            DisplayRules();
            UserInterface.setName();
            UserInterface.DisplayWelcome();
            player.wallet.DisplayMoneyInWallet();
            PurchaseInventory();
            player.wallet.PayMoneyForItems(transactionAmount);
            player.wallet.DisplayMoneyInWallet();
           
            Console.WriteLine("Your Recipe makes 10 cups");
            Console.WriteLine("Would you like to change your recipe?");
            Console.WriteLine("Yes or No");
            string input = Console.ReadLine();
            switch(input)
            {
                case "No":
                case "no":
                    break;
                case "yes":
                case "Yes":
                    break;
            }
            Console.WriteLine("Please choose from the list of options: 'Lemons', 'Sugar Cubes','Ice' and price per cup of 'Lemonade' ");
            player.recipe.ChangeRecipe(player);
            
            

        }
        public void ListOfDays()
        {
            List<string> days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wendesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");

            foreach (string day in days)
            {
                Console.WriteLine(day);
            }
        }
        // public void SellLemonade()
        // {

        //    for (int i = 0; i < cupsLeftInPitcher.length; i++)
        //     {

        //     }  
        //  }


        public void RunGame()
        {
            RunDay();
           
            
            
            

        }
    }
}
