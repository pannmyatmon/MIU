using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isNUnique
    {
        //int a[] =  {2, 7, 3, 4};
        // int i = 5
        //  int[] e = { 7, 3, 3, 2, 4 };
        // int n5 = 6;

        public static int isNUniqueCheck(int[] a, int n)
        {
            if (a.Length < 2)
            {
                return 0;
            }
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > n)
                {
                    continue;
                }
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (n == a[i] + a[j])
                    {
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                return 1;
            }
            return 0;
        }
    }
}
