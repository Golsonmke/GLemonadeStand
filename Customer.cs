using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {
      
        public string name;
        public List<string> names;
        bool willBuy;

       
        public Customer()
        {
            this.willBuy = false;

        }
        //pricePerCup == RAndom number between price range 
        public bool BuyProbability(Weather weather, Recipe recipe)
        {
            

            
            
                if ((weather.temperature >= 90) && (recipe.pricePerCup <= .99))
                {
                    willBuy = true;
                  
                }
                else if ((weather.temperature >= 80) && (recipe.pricePerCup <= .79))
                {

                    willBuy = true;
                   
                }
                else if ((weather.temperature >= 70) && (recipe.pricePerCup <= .59))
                {
                    willBuy = true;
                   

                }
                else if ((weather.temperature >= 60) && (recipe.pricePerCup <= .29))
                {
                    willBuy = true;
                   
                }
                else if ((weather.temperature <= 60) && (recipe.pricePerCup >= .10))
                {
                    willBuy = false;
                   
                }
            return willBuy;
           




        }

    }

}
