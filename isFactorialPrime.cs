using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{

    // C# program to check if given
    // number is a factorial prime
    // page 42 Set A - No1

    public static class isFactorialPrime
    {

        // Utility function to check
        // if a number is prime or not
        static bool isPrime(long n)
        {
            // Corner cases
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;

            // This is checked so that we can skip
            // middle five numbers in below loop
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        // Function that returns true if n is a factorial prime
        public static bool isFactorialPrimeCheck(long n)
        {

            // If n is not prime then return false
            if (!isPrime(n))
                return false;

            long fact = 1;
            int i = 1;
            while (fact <= n + 1)
            {

                // Calculate factorial
                fact = fact * i;

                // If n is a factorial prime
                if (n == fact + 1)
                    return true;

                i++;
            }

            // n is not a factorial prime
            return false;
        }

        public static int IsFactorialPrime(int num)
        {
            //check for prime
            for (var i = 2; i < num; i++)
                if (num % i == 0)
                    return 0;

            //check for factorial
            int fVal;
            var f = 1;
            do
            {
                fVal = 1;
                for (var i = 1; i <= f; i++)
                    fVal *= i;

                fVal += 1;
                f++;
            } while (fVal < num);

            if (fVal != num)
                return 0;

            return 1;
        }

    }
}

        
    



