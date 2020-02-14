using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {

        int time;
        string weekDay;

        public Day()
        {
            time = 0;
        }
        public void TimeOfDay()
        {

        }
        public void DayOfTheWeek()
        {
            List<string> weekDay = new List<string>();
            weekDay.Add("Monday");
            weekDay.Add("Tuesday");
            weekDay.Add("Wendesday");
            weekDay.Add("Thursday");
            weekDay.Add("friday");
            weekDay.Add("saturday");
            weekDay.Add("Sunday");


        }
    }

}
