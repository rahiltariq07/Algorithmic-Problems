using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class RemoveSpecificChars
    {
        static void Main()
        {
            string input = "Rahil Tariq";
            string vowels = "aeiouAEIOU";

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                //if (c == ' ')
                //    continue;

                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }
            Console.WriteLine("String without vowels: " + result.ToString());
        }
    }
}
