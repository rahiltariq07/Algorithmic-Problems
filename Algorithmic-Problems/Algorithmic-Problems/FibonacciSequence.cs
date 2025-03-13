using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class FibonacciSequence
    {
        static void Main()
        {
            Console.Write("Enter the number of terms for Fibonacci sequence: ");
            int terms = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
