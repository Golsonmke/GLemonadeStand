using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public int temperature;
        public string condition;
        
       

        public Weather()
        {
            this.temperature = 55;
            this.temperature = 100;
            

           
        }
        public void WeatherType()
        {
            List<string> condition = new List<string>();
            condition.Add("Cloudy");
            condition.Add("Overcast");
            condition.Add("rainy");
            condition.Add("Hazy");

            var rnd = new Random();
            Console.WriteLine("Forcast " + condition[rnd.Next(0, condition.Count)]);

        }
        public void RandomTemperature()
        {
            Random temperature = new Random();
            Console.WriteLine(temperature.Next(55, 100));

        }
        public void DisplayWeather()
        {   
                WeatherType();
                RandomTemperature();
                Console.WriteLine();
        }
        
    }
}
