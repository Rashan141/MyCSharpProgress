using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Exercises
{
    class TimeAsk
    {
        public static void PostYourTime(string input){

            var itsOk = true;

            Console.WriteLine(input);

            string[] hoursToMinutes = input.Split(':');

            if (Convert.ToInt32(hoursToMinutes[0]) > 23)
            {
                itsOk = false;
            }
            else if (Convert.ToInt32(hoursToMinutes[1]) > 59) {
                itsOk = false;
            }

            if (itsOk)
                Console.WriteLine("IT's good.");
            else {
                Console.WriteLine("Your time is invalid.");
            }
        }
    }
}
