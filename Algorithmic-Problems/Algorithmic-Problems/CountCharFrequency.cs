using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class CountCharFrequency
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ')
                    continue;

                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }
        }
    }
}
