using System;
using System.Collections.Generic;

namespace SeperatePrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = 0; i <= 100000; i++)
            {
                if(CheckIfPrime(i) == true)
                {
                    primeNumbers.Add(i);
                }
            }

            foreach(int item in primeNumbers)
            {
                Console.WriteLine(item + " is a prime number.");
            }

        }

        public static bool CheckIfPrime(int numToCheck)
        {
            if(numToCheck == 1 || numToCheck == 0)
            {
                return false;
            }
            for (int a = 2; a <= Math.Sqrt(numToCheck); a++)
            {
                if(numToCheck % a == 0)
                {
                    Console.WriteLine(numToCheck + " is not a prime.");
                    return false;
                }
            }
            return true;
        }
    }
}
