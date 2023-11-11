using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    class reverse
    {
       public static int reverseInt(int n)
        {
            int sign = 1;
            if (n == 0) return 0;

            if (n < 0)
            {
                sign = -1;
                n = -n;
            }

            int reverse = 0;


           while( n != 0)
            {
                reverse = (reverse * 10) + (n % 10);
                n /= 10;
                
            }

            return sign * reverse;
            
        }
    }
}
