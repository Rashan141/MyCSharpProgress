using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mess_Around
{
    public enum SpaceShipping {
           Basic = 1,
           Inter = 2,
           Extra = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Int32)SpaceShipping.Basic);
        }
    }
}
