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
            this.lemonadeValue = lemonadeValue;
            List<string> names = new List<string>();
            names.Add("Peter");
            names.Add("Sam");
            names.Add("Fred");
            names.Add("Linda");
            names.Add("Gary");
            names.Add("Avi");
            names.Add("Rebecca");
            names.Add("Bob");
            names.Add("Dillon");
            names.Add("Rikki");
            names.Add("John");
            names.Add("Dick");
            names.Add("Tom");
            names.Add("Harry");
            names.Add("Bill");

            

        }
        public void CustomersBuyProfile(int minimum, int maximum, Random random)
        {
            int willBuy = random.Next(1, 25);
            lemonadeValue = (willBuy / 10);
        }
    }

}
