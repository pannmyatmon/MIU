using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class getExponent
    {
        //  getExponent(162, 3)/ 280 , 7
        public static int getExponentCheck(int n, int p)
        {
            if (p <= 1)
                return -1;

            int count = 0;

            n = n > 0 ? n : -n;

            for (int num = n; num > 0; num /= p)
            {
                if (num % p == 0)
                
                    count++;

                else
                    break;

            }

            return count;
        }
    }
}
