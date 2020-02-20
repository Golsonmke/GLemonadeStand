using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
     public class Pitcher
    {
        public int cupsLeftInPitcher;



        public Pitcher()
        {

            

        }
        public void CupsLeftInPitchers()  ///Single Responsibility because the pitcher only hold the Lemonade.
        {
             cupsLeftInPitcher = 10;
        }

    }
    
}

