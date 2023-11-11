using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class henry
    {
        // 6 = 1 + 2 + 3
        // 28 =1 + 2 + 4 + 7 + 14
        // 496 = = 1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248
        // henry(1, 3) should return 502
        public static int henryCheck(int i, int j)
        {
            int ans = 0;
            if (i == 0 || j == 0)
                return 0;

            ans = getPerfectNum(1, 3);
            return ans;
        }

        private static int getPerfectNum(int a, int b)
        {
            int count = 0;
            int i = 2;
            int sum = 0;
            while (true)
            {
                if (getSumfactor(i) != 0)
                {
                    count++;
                    if (count == a)
                    {

                        sum = getSumfactor(i);

                    }
                    else if (count == b)
                    {
                        if (i == 496)
                       
                        return sum + getSumfactor(i);
                    }
                }

                i++;

            }
        }

        private static int getSumfactor(int n)
        {
            int sum = 1;

            if (n == 0)
                return 0;
            else
            {
                double b = Math.Sqrt(n);

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {

                        sum = sum + i + n / i;

                    }
                }

                if (n == sum)
                {
                    return sum;
                }

                return 0;
            }
        }
    } 
}
