using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    // Qs Set C No.1 page - PG38 
    public static class isZeroPlentiful
    {
        //{0, 0, 0, 0, 0}
        // {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0}1 /   3
        public static int isZeroPlentifulCheck(int[] a)
        {
            if (a.Length < 4)
                return 0;

            int count = 0;

            for (int i = 0; i < a.Length - 1;)
            {
                if (a[i] == 0 && i + 3 <= a.Length)
                {
                    int j = i;
                    int zeroCount = 0;

                    while (j < a.Length && a[j] == 0)
                    {
                        zeroCount++;
                        j++;
                    }

                    if (zeroCount < 4)
                    {
                        return 0;
                    }
                    else
                    {
                        count++;
                    }

                    i = j;
                }
                else i++;
            }

            return count;
        }
    }
}
