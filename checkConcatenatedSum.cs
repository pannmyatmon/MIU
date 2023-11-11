using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class checkConcatenatedSum
    {
        //198 2 1 because 198 == 11 + 99 + 88
        // 198 3 0 because 198 != 111 + 999 + 888
        public static int checkConcatenatedSumCal(int n, int catlen)
        {
            int tempNum = n;
            int sum = 0;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;

                for (int i = 1, j = 1; j <= catlen; i *= 10, j++)
                {
                    sum += digit * i;
                }

            }
            if (n == sum)
                return 1;

            else return 0;
        }
    }
}
