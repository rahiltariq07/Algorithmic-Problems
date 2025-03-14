using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class ExtractNums_SumThem
    {
        static void Main()
        {
            Console.WriteLine("Enter a string with numbers: ");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    sum += digit;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
