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
    // {1, 3, 2}
    //  { 1, 3 };
    //{1, 2, 1, 2, 1, 2, 1,2, 1}
public static class isMartian
    {
        public static int isMartianArray(int[] input)
        {
            
                var ones = 0;
                var twos = 0;
                for (int i = 0, j = 1; i < input.Length; i++, j++)
                {
                    if (j < input.Length)
                        if (input[i] == input[j])
                            return 0;

                    if (input[i] == 1)
                        ones++;

                    if (input[i] == 2)
                        twos++;
                }

                if (twos >= ones)
                    return 0;

                return 1;
            
        }
    }
}
