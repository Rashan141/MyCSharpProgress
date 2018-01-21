using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessRight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessedRight = false;
            var random = new Random();
            int randNum = random.Next(0, 10);
            int counter = 4;

            while (counter > 0 && guessedRight !=true)
            {
                Console.WriteLine("Guess the number.");
                int guess = Convert.ToInt32(Console.ReadLine());

                    if(guess == randNum)
                    guessedRight = true;

                counter--;
            }

            if (counter > 0 || guessedRight == true)
                Console.WriteLine("Congratz");
            else
            {
                Console.WriteLine("Ya dun goofed. The answer was " + randNum);
            }
        }
    }
}
