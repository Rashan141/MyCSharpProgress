using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepMeTalking
{
    partial class Program
    {
        public enum Rankings {
            King = 1,
            Queen = 1,
            Duke = 3,
            Duchess = 3,
            Baron = 4,
            Mistress = 4,
            Peasant = 5
        }

        static void Main(string[] args)
        {
            List<Caste> people = new List<Caste>();
            Random mix = new Random();

            int leftScore = 0;
            int rightScore = 0;

            for (int i = 0; i < 7; i++)
            {
                people.Add(new Caste());
            }

            while (leftScore < 7 && rightScore < 7)
            {

                var left = people[mix.Next(0, 7)];
                var right = people[mix.Next(0, 7)];

                var leftPower = Enum.Parse(typeof(Rankings), left.GetTitle());
                var rightPower = Enum.Parse(typeof(Rankings), right.GetTitle());

                Console.WriteLine("It's {0} vs {1}", left.FullStatus(), right.FullStatus());

                if ((Rankings)leftPower < (Rankings)rightPower)
                {
                    Console.WriteLine("{0} is of a higher status", left.FullStatus());
                    leftScore++;
                }
                else if ((Rankings)rightPower < (Rankings)leftPower)
                {
                    Console.WriteLine("{0} is of a higher status", right.FullStatus());
                    rightScore++;
                }
                else {
                    Console.WriteLine("Both of them are the same rank.");
                }

                Console.WriteLine("leftScore: {0}  rightScore: {1}", leftScore, rightScore);

                Console.WriteLine();
            }

            //var input = Console.ReadLine();
            //while (!String.IsNullOrWhiteSpace(input)) {
            //    Console.WriteLine(input);
            //    Console.WriteLine();

            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Goodbye");
        }
    }
}
