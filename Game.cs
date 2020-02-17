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

        Player player;
        List<Day> days;
        int currentDay;
        Store store;

        public Game()
        {
            player = new Player();
            store = new Store();
        }
        public void displayRules()
        {
            Console.WriteLine("Lemonade Stand");
            Console.WriteLine("You have 7 days to make as much money as possible, and you've decided to open a lemonade stand! /r/n" +
                "You'll have Complete control over your buisness, including pricing, quality control inventory control and purchasing supplies. /r/n" +
                "Buy you ingridients and start selling! ");
            Console.WriteLine();
            Console.WriteLine("The first thing you'll have to worry about is your recipe. At first, go with /r/n" +
                "the default recipe, but try to experiment a little bit and see if you can find /r/n" +
                "a better one. Make sure you buy enough of all your ingridients, or you/r/n" +
                "won't be able to sell!" );
            Console.WriteLine("You'll also have to deal with the weather, which will play a big part when/r/n" +
                "customers are deciding wether or not to buy your lemonade. Read the /r/n" +
                "weather report every day! When the weather drops, or the weather/r/n" +
                "turns bad (overcast, cloudy, rain) don't expect them to buy nearly as/r/n" +
                "muchas they would on a hot, hazy day, so buy accordingly. Feelfree to /r/n" +
                "set your prices higher on those hot, muggy days too, as you'll make/r/n" +
                "more profit, even if you sell a bit less lemonade");
            
        }
        public void PurchaseInventory()
        {

        }
        public void QualityControl()
        {

        }

       
        public void RunGame()
        {
            displayRules();

            store.SellLemons(player);
        }
    }
}
