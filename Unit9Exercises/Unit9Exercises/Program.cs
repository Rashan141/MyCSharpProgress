using System;
using System.Collections.Generic;
using System.IO;

namespace Unit9Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines(@"c:\Users\Rasha\Desktop\Temp Text.txt");

            var biggestWord = "";
            var wordLength = 0;
            List<string> words = new List<string>();

            foreach (var line in lines)
            {
                words.AddRange(line.Trim().Split(' '));

            }


            foreach (var word in words)
            {
                if (wordLength < word.Length)
                    biggestWord = word;
            }

            Console.WriteLine("This is all the text in the file: ");
            foreach(var pass in lines)
            Console.WriteLine(pass);
            Console.WriteLine("This is how many words are in the file itself: " + words.Count);
            Console.WriteLine("This is the biggest word in the text: " + biggestWord);
        }
    }
}
