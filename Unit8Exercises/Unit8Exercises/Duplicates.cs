using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Exercises
{
    class Duplicates
    {
        public static bool IsDuplicates(string input) {

            Console.WriteLine(input);

            var dupeCount = 0;

            string[] separate = input.Split('-');
            List<int> numbers = new List<int>();

            foreach (string a in separate)
            {
                numbers.Add(Convert.ToInt32(a));
            }

            foreach (var num in numbers) {
                for (int i = 0; i < numbers.Count; i++) {

                    if (num == numbers[i])
                        dupeCount++;

                    if (dupeCount > 1) {
                        return false;
                    }

                }

                dupeCount = 0;
            }
            return true;
        }
    }
}
