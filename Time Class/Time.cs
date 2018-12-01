using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Class
{
    class Time
    {
        private int hours, mins, secs;


         public Time(int inputHour)
        {
            hours = inputHour;

        }




        public Time(int theHour, int theMins, int theSecs)
        {
            hours = theHour;
            mins = theMins;
            secs = theSecs;
        }



        public string GetCurrentTime()
        {
            string output = "";

            output = "Time is " + hours.ToString("00") + ":"
                      + mins.ToString("00") + ":"
                      + secs.ToString("00");


            return output;
        }

        
    }// End of Class
}
