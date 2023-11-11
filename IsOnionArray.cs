using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   public static class IsOnionArray
    {
        //{-2, 5, 0, 5, 12}
        // pg 40 qs set C No1
        public static int IsOnionArrayCheck(int[] a)
        {
            // a = 5
             // k = 5
            for (int j = 0, k = a.Length; j < a.Length; j++, k--)
                if (j + k == a.Length)
                {
                    if (j != k-1)
                    {
                        if (a[j] + a[k-1] > 10)
                            return 0;
                    }
                    else
                        break;
                }

            return 1;
        }


       //public static int isOnionArrayJV(int[] a)
       // {
       //     if (a.Length == 1 || a.Length == 0)
       //         return 1;

       //     for (int i = 0, j = a.Length - 1; i < j; i++, j--)
       //     {
       //         if (i + j == a.Length)
       //         {
       //             if (a[i] + a[j] > 10)
       //                 return 0;
       //         }
       //     }
       //     return 1;
       // }
    }
}
