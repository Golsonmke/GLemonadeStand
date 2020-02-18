using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {
      
        public string names;
        public double lemonadeValue;

        

        public Customer()
        {
            
            List<string> names = new List<string>();
            

            

        }
        public void CustomersBuyProfile(int minimum, int maximum, Random random)
        {
            int willBuy = random.Next(1, 25);
            lemonadeValue = (willBuy / 10);
        }

    }

}
