using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public  class largestPrimeFactor
    {
        public  int largestPrimeFactorCheck(int n)
        {
            if (n <= 0)
                return 0;

            int largestPrimeFactor = 2;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && isPrime(i))
                {
                    largestPrimeFactor = i;
                }
            }

            return largestPrimeFactor;
        }

        private bool isPrime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0)
                   return false;

            }

            return true; ;
        }

    }
}
