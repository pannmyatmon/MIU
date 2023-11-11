using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    /*
 Page - 46 - 
=========
computeHMS - Set 1
1.computeHMS int[] computeHMS(int seconds);
2.Martian array -> int isMartian(int[ ] a)  === Done*
3.paired-N -> int isPairedN(int[ ] a, int n) - . Once you know the array is paired-N, you should return 1. No wasted loop iterations please.
*/
    //{1, 4, 1, 4, 5, 6}
    public static class paired_N
    {
        public static int isPairedN(int[] a, int n)
        {
          

            var max = (a.Length - 1) + (a.Length - 2);
            if (n > max)
                return 0;

            for (var i = 0; i < a.Length; i++)
            {
                 var j = n - i;
              
                if (j > a.Length - 1 || j < 0)
                    continue;

                if (i + j == n && a[i] + a[j] == n)
                    return 1;
            }


            return 0;
        }
    }
}
