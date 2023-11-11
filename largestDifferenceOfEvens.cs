using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class largestDifferenceOfEvens
    {
        //43 - 3 setA

        public static int largestDiffOfEvens(int[] a)
        {
            int largestDiff = 0;

            int maxeven = 0, mineven = 0, evencount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (evencount == 0)
                    {
                        maxeven = a[i];
                        mineven = a[i];
                    }
                    evencount++;
                    if (a[i] > maxeven)
                    {
                        maxeven = a[i];
                    }
                    if (a[i] < mineven)
                    {
                        mineven = a[i];
                    }
                }
            }
            largestDiff = maxeven - mineven;

            if (evencount < 2)
            {
                largestDiff = -1;
            }

            return largestDiff;



        }
    }
}
