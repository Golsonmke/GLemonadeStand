using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Weather weather;
        Inventory Inventory;

        public Game()
        {
            weather = new Weather();

        }
        public void DisplayWeather()
        {
            int counter = 0;
            do
            {
                weather.WeatherType();
                weather.RnadomTemperature();
                Console.WriteLine();

                counter++;

            }
            while (counter < 8);
        }
        public void RunGame()
        {
            DisplayWeather();
           
        }
    }
}
