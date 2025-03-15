using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class FindUniqueChars
    {
        static void Main()
        {
            string input = "hello";

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            Console.WriteLine("Unique characters (appear only once):");

            foreach (var pair in frequency)
            {
                if (pair.Value == 1)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}
