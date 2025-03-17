using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class CountVowelsAndConstants
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            string vowels = "aeiouAEIOU";

            int vowelsCount = 0;
            int constsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLetter(c))
                {
                    if (vowels.IndexOf(c) != -1)
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        constsCount++;
                    }
                }
            }

            Console.WriteLine("Vowels Count: " + vowelsCount);
            Console.WriteLine("Constants Count: " + constsCount);
        }
    }
}
