using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isHodder
    {
        public static int isHolderCheck(int n)
        {
            int isHolder = 0, j = 0, cal = 0;
            
            if (checkPrime(n))
            {
                do {
                    cal = (int)(Math.Pow(2, j)) - 1;
                    if (cal == n)
                        isHolder = 1;
                    j++;
                }
                while (cal <= n && isHolder == 0);
                
            }
            return isHolder;
        }

        private static bool checkPrime(int n)
        {
            bool isPrime = false;
            if( n % 2 != 0)
            {  
                isPrime = true;
             
            }

            return isPrime;
        }
    }
}
