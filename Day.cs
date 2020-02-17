using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers;


        public Day()
        {
           
        }
      
        public void DayOfTheWeek()
        {
            List<string> days= new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wendesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");


        }
    }

}
