using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Exercises
{
    class Consecutive
    {
        static public bool Consecutives(string input) {

            Console.WriteLine(input);

            string[] separate = input.Split('-');

            List<int> numbers = new List<int>();

            foreach (string a in separate)
            {
                numbers.Add(Convert.ToInt32(a));
            }

            var isIncreasing = false;
            var isDecreasing = false;

            int basic = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (basic == numbers[i])
                    return false;

                if (basic < numbers[i] && basic !=0)
                {
                    if ((basic - numbers[i]) == -1)
                    {
                        isIncreasing = true;
                        basic = numbers[i];
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (basic > numbers[i] && basic != 0)
                {
                    if ((basic - numbers[i]) == 1)
                    {
                        isDecreasing = true;
                        basic = numbers[i];
                        continue;
                    }
                    else { 
                        return false;
                    }
                }

                if (isIncreasing == true && isDecreasing == true)
                {
                    return false;
                }

                basic = numbers[i];
            }
            
            return true;
        }

        static private bool increasing(){


            return true;
        }
    }
}
