using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Exercises
{
    class MakePascal
    {
        public static void ItsNowPascal() {
            Console.WriteLine("Let's make some Pascal together");

            var input = Console.ReadLine();
            string wordIsChanged;
            List<string> fixTheWords = new List<string>();
            var builtString = new StringBuilder();

            foreach (var each in input.Split(' ')) {
                fixTheWords.Add(each);
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            for (int i = 0; i < fixTheWords.Count; i++)
            {
                wordIsChanged = fixTheWords[i].ToString().ToLower();
                wordIsChanged = wordIsChanged[0].ToString().ToUpper() + wordIsChanged.Substring(1, wordIsChanged.Length);

                builtString.Append(wordIsChanged);
            }

            Console.WriteLine(builtString);
        }

        private static string FixUp(string word){


            return word;
        }
    }
}
