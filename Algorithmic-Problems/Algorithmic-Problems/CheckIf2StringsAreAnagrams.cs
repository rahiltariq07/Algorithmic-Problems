using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Problems
{
    internal class CheckIf2StringsAreAnagrams
    {
        static void Main()
        {
            Console.WriteLine("Enter String 1: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter String 2: ");
            string str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not an Anagram");
                return;
            }

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not an Anagram");
                    return;
                }
            }

            Console.WriteLine("Anagram");
        }
    }
}