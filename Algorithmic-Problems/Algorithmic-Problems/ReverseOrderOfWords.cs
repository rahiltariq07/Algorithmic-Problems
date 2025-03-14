using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class ReverseOrderOfWords
    {
        static void Main()
        {
            Console.WriteLine("Write a sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Array.Reverse(words);

            string output = string.Join(" ", words);

            Console.WriteLine(output);
        }
    }
}
