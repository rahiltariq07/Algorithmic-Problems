using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class RemoveDuplicateChars
    {
        static void Main()
        {
            Console.WriteLine("Enter a String: ");
            string input = Console.ReadLine();

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (result.IndexOf(c) == -1)
                {
                    result += c;
                }
            }

            Console.WriteLine("String after removing duplicates: " + result);
            Console.ReadLine();
        }
    }
}
