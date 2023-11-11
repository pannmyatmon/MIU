using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   public static class commonArray
    {
        // {1, 8, 3, 2}, {4, 2, 6, 1}	{1, 2}

        public static int[] commonArryCheck(int[] first, int[] second)
        {

            if (first == null || second == null)
                return null;


            if (first.Length == 0 || second.Length == 0)
                return new int[0];


            int min = (first.Length < second.Length) ? first.Length : second.Length;
            int[]  a, b;

            if (min == first.Length)
            {
                a = first;
                b = second;
            }
            else
            {
                a = second;
                b = first;
            }

            int[] c = new int[min];
            int k = 0;

            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                    { 
                        c[k] = a[i];
                        k++;
                    }

            int[] retArry = new int[k];
            for (int t = 0; t < retArry.Length; t++)
            {
                retArry[t] = c[t];
                
            }


            return retArry;

        }

    }
}
