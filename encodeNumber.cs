using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class encodeNumber
    {
        // 6936
        // 6936=2*2*2*3*17*17
        // {2, 2, 2, 3, 17, 17}
        public static int[] encodeNumberMethod(int n)
        {
            if (n <= 1)
                return null;

            int count = 0;
            int nAsign = n;

            for (int i = 2; i <= nAsign;)
            {
                if (isPrime(i) && nAsign % i == 0)
                {
                    count++;
                    nAsign /= i;
                }
                else
                    i++;
            }

            int[] result = new int[count];
            nAsign = n;

            for (int i = 0, j = 2; i < count && j <= nAsign; )
            {
                if (isPrime(j) && nAsign % j == 0)
                {
                    result[i] = j;
                    i++;
                    nAsign /= j;
                }
                else j++;
            }
            return result;

            
        }

        public static bool isPrime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % 2 == 0)
                    return false;
            }
        
                return true;
        }
    }
}
