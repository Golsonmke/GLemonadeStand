using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        int temperature;
        string forcast;
        
        

        public Weather()
        {
            temperature = 55;
            temperature = 100;


           
        }
        public void WeatherType()
        {
            List<string> forcast = new List<string>();
            forcast.Add("Cloudy");
            forcast.Add("Overcast");
            forcast.Add("rainy");
            forcast.Add("Hazy");

            var rnd = new Random();
            Console.WriteLine("Forcast " + forcast[rnd.Next(0, forcast.Count)]);

        }
        public void RnadomTemperature()
        {
            Random temperature = new Random();
            Console.WriteLine(temperature.Next(55, 100));

        }


    }
}
