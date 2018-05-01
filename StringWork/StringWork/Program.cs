using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //float price = 49.95f;
            //Console.WriteLine(price.ToString("C"));

            var sentence = "This is going to be an obscenely, ridiculously, outrageously, unseemly, Crazily, insanely long sentence for no reason.";
            var sentence2 = "Very short one.";

            Console.WriteLine(StringUtility.SummarizeText(sentence));
            Console.WriteLine(StringUtility.SummarizeText(sentence2));
        }

    }
}
