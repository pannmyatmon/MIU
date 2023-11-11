using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    // page 40 - setB no.2
    public static class isPrimeHappy
    {

        //25
        static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;  
                }

            }
            return true;
        }


        public static int isPrimeHappyCheck(int n)
        {
            int num = 2;
            bool primeFlag = false;
            int sum = 0;


            while (num < n)
            {
                if (isPrime(num))
                {
                    primeFlag = true;
                    sum += num;
                }
                num++;
            }
            if (primeFlag && sum % n == 0)

                return 1;

            else return 0;


        }
    }
}
