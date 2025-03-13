//using System;

//namespace Algorithmic_Problems
//{
//    internal class CheckPrime
//    {
//        static void Main()
//        {
//            Console.Write("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());

//            if (num <= 1)
//            {
//                Console.WriteLine(num + " (not prime)");
//                return;
//            }

//            bool isPrime = true;
//            for (int i = 2; i <= Math.Sqrt(num); i++)
//            {
//                if (num % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }

//            if (isPrime)
//            {
//                Console.WriteLine(num + " (prime)");
//            }
//            else
//            {
//                Console.WriteLine(num + " (not prime)");
//            }
//        }
//    }
//}
