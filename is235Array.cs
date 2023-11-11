using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Page - 46 -- Set 2

1. A number n is triangular if n == 1 + 2 +…+j for some j. -- Done*
2. Define an array to be a Mercurial array if a 3 does not occur -- Done * 
3. An array is defined to be a 235 array
 */
namespace MUI
{
    public static class is235Array
    {
        public  static int is235ArrayCheck(int[] a) 
        {
            int div2 = 0;
            int div3 = 0;
            int div5 = 0;
            int nonDiv = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 || a[i] % 3 == 0 || a[i] % 5 == 0)
                {
                    if (a[i] % 2 == 0)
                        div2++;
                    if (a[i] % 3 == 0)
                        div3++;
                    if (a[i] % 5 == 0)
                        div5++;

                }
                else
                {
                    nonDiv++;
                }
            }

            if (div2 + div3 + div5 + nonDiv == a.Length)
            {
                return 1;
            }


            return 0;
        }
    }
}
