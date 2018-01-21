using System;
using System.Collections.Generic;

namespace MessAround
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 1, 2, 3 });
        }
    }
}
