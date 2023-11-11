using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   // int[] a = { 3, 2, 0, 5, 3 };
   // int n = 32053;
    public static class repsEqual
    {
        public static int repsEqualCheck(int[] a, int n)
        {
            int idx = 0;
            double res = 0;
            while (a[idx] == 0)
            {
                idx++;
            }
            for (; idx < a.Length; idx++)
            {
                res += a[idx] * Math.Pow(10, a.Length - 1 - idx);

            }
            if (res == n)
            {
                return 1;
            }
            else
                return 0;

        }

        public static int repsEqualCheck1(int[] a, int n)
        {
            
            int index = 0;
            double res = 0;
            while (a[index] == 0)
            {
                index++;
            }
            for (; index < a.Length; index++)
            {
                res += a[index] * Math.Pow(10, a.Length - 1 - index);
            }
            if (res == n)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    
}
