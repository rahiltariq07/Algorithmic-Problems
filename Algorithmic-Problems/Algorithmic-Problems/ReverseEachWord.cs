using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class ReverseEachWord
    {
        static void Main()
        {
            string input = "Rahil Tariq";

            string[] words = input.Split(' ');

            string reversedInput = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                StringBuilder reversedWord = new StringBuilder();

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord.Append(word[j]);
                }

                reversedInput += reversedWord.ToString() + " ";
            }
            Console.WriteLine(reversedInput);
        }
    }
}
