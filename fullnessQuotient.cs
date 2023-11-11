using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class fullnessQuotient
    {
        public static int fullnessQuotientCheck(int n)
        {
            if (n < 1)
                return -1;
            int count = 0;

            for (int _base = 2; _base <= 9; _base++)
            {
                bool zeroFlag = false;

                for (int num = n; num > 0; num /= _base) // base ==4 , no zero| base 5 = no zero| base 6,
                {
                    if (num % _base == 0)
                    {
                        zeroFlag = true;
                        break;
                    }
                }
                if (!zeroFlag)
                    count++;
            }
            return count;
            

        }
    }
}
