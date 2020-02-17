﻿using System;
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

        Player player;
        List<Day> days;
        
        Store store;
        Wallet wallet;
        Weather weather;
        Inventory inventory;
        
        
       


        public Game()
        {
           
            player = new Player();
            store = new Store();
            inventory = new Inventory();
            weather = new Weather();
           

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

       
        public void RunGame()
        {
            DisplayRules();
            weather.DisplayWeather();

            PurchaseInventory();




        }
    }
}
