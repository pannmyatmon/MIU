using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class PrimeCount
    {  // 2 , 13 - 2,3,5,7,11,13
        // 11 - 29 - 10
       
            public static int PrimeCountCheck(int start, int end)
            {
             if (end == 1) return 0;

            if (start < 1)
                start = 2;

            if (start > end)
                return 0;
   
                int result = 0;

            for (; start <= end; start++)
                {
                    bool isPrime = true;
                    for (int i = 2; i < start; i++)
                    {     
                        if (start % i == 0)
                            isPrime = false;
                    }

                    if (isPrime)
                        result++;
                    
                }
                return result;
        }
    }
}
