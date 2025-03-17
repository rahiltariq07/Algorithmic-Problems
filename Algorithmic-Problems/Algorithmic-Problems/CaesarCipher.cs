using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class CaesarCipher
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int shift = 3;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c >= 'a' && c <= 'z')
                {
                    c = (char)((c - 'a' + shift) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)((c - 'A' + shift) % 26 + 'A');
                }

                result += c;
            }

            Console.WriteLine(result);
        }
    }
}
