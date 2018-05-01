using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseline = "8-7-6-9";
            Console.WriteLine("It is consecutive: {0}", Consecutive.Consecutives(baseline));

            Console.WriteLine();

            baseline = "1-2-3-4-3-6-7";
            Console.WriteLine("There are duplicates in this string: {0}", Duplicates.IsDuplicates(baseline));

            Console.WriteLine();

            baseline = "19:44";
            TimeAsk.PostYourTime(baseline);

            Console.WriteLine();

            MakePascal.ItsNowPascal();
        }
    }
}
