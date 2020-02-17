using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public Customer customer;

        // constructor (SPAWNER)
        public Player()
        {
            this.name = "Name";
            wallet = new Wallet();
            inventory = new Inventory();
            customer = new Customer();
            recipe = new Recipe();
        }
        

             // member methods (CAN DO) purschase items, sell lemonade
    }  
}
