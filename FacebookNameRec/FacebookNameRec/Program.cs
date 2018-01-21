using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookNameRec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of your Likes, until you have none.");
            var nameBase = new List<string>();

            var nameInput = Console.ReadLine();

            string post = "Your post was liked by ";
            while (nameInput != "")
            {
                nameBase.Add(nameInput);
                var count = nameBase.Count;
                post = "Your post was liked by ";

                if (count == 1)
                {
                    post += nameBase[count-1];
                    Console.WriteLine(post);
                }
                else if (count == 2)
                {
                    post += nameBase[count-1] + ", " + nameBase[count-2];
                    Console.WriteLine(post);
                }
                else
                {
                    post += nameBase[count - 1] + ", " + nameBase[count-2] + ", and " + (count-2) + " others";
                    Console.WriteLine(post);
                }

                Console.WriteLine("Enter nothing at all to finish.");
                nameInput = Console.ReadLine();
            }

        }
    }
}
