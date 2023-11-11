using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    //{2, -3, -2, 6, 9, 18} encodes the number 51839
    // 2 - (-3) = 5
    // -3 - (-2) = -1 
    // -2 - 6 = - 8
    // 6 - 9 = -3
    // 9 - 18 = 9


    public static class decodeArrayfromencodedInt
    {
        //{2, -3, -2, 6, 9, 18}
        // length = 6
        public static int decodeArray(int[] a)
        {
            int sum = 0;
            for (int i = a.Length - 1; i > 0; i--) // i = 5, i = 4
            {
                int digit = (a[i] - a[i - 1]) > 0 ? (a[i] - a[i - 1]) : -(a[i] - a[i - 1]); // 9 , 3

                for (int j = i; j < a.Length - 1; j++) // ( i and j == 6,  digit = 30
                {
                    digit *= 10;

                }
                sum += digit;
            }
            if (a[0] < 0)
                return -sum;
            else
               return sum;
        }
    }
}
