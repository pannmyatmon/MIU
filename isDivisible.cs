using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
/*
    int[] a = { 3, 3, 6, 36 };
    int n = 3;
*/
    public static class isDivisible
    {
        public static int isDivisibleCheck(int[] a, int n)
        {
            int[] newarr = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % n == 0)
                    count++;
            }

            if (count == a.Length)
            {
                return 1;
            }

            return 0;
        }

    }
}
