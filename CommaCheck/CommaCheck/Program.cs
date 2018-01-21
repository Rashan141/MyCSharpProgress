using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommaCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a series of numbers, separated by a comma.");
            var input = Console.ReadLine().Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            Console.WriteLine(input.Length);
            int biggest = 0;
            int convNum;
            foreach (var num in input)
            {
                convNum = Convert.ToInt32(num);
                if (biggest < convNum)
                    biggest = convNum;
            }

            Console.WriteLine("This was your biggest number: " + biggest);

        }
    }
}
