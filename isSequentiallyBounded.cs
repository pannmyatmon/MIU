using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isSequentiallyBounded
    {
        // {0, 1} => 0
        // {-1, 2} => 0
        // {} => 1
        // {5, 5, 5, 5}{5, 5, 5, 5} => 1
        // {5, 5, 5, 2, 5} => 0
        // {2, 3, 3, 99, 99, 99, 99, 99}  = > 1
        public static int isSequentiallyBoundedCheck(int[] a)
        {
            if (a.Length == 0)
                return 1;

            int x = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[0] < 0) return 0;

                if (x > a[i])
                {
                    return 0;
                }
                x = a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                int allowedCount = a[i] - 1;
                int actulCount = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == a[i])
                    {
                        actulCount++;
                    }
                }
                if (actulCount > allowedCount)
                    return 0;
            }

            return 1;
        }
    }
}
