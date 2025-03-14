using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class Encoding
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    output.Append(input[i - 1]);

                    if (count > 1)
                    {
                        output.Append(count);
                    }
                    count = 1;
                }
            }

            output.Append(input[input.Length - 1]);

            if (count > 1)
            {
                output.Append(count);
            }

            Console.WriteLine(output.ToString());
        }
    }
}
