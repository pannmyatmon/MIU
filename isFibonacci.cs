using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isFibonacci
    {
        //      int f = 13;
        public static int isFibonacciCheck(int n)
        {
            if (n == 0)
                return 1;
            int x = 1;
            int y = 1;
            int z = 0;

            for (int i = 1; i <= n; i++)
            {
                z = x + y;
                if (z == n)
                {
                    return 1;
                }

                x = y;
                y = z;

            }
            return 0;
        }
    }
}
