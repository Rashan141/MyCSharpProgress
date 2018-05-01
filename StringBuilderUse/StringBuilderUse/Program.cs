using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderUse
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder.Append('+', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('+', 10);

            builder.Replace('+', '-');


            Console.WriteLine(builder);
        }
    }
}
