using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isSequencedArray
    {
        // {2, 2, 3, 4, 4, 4, 5} is a 2-5 
        public static int isSequencedArrayCheck(int[] a,int m, int n)
        {
            if (a.Length <= 1 || a[0] != m || a[a.Length - 1] != n || m > n)
                return 0;

            for (int i = m; i <= n; i++)
            {
                bool isSequence = false;

                for (int j = 1; j <= a.Length - 1; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        return 0;
                    }

                    if (a[j - 1] == i || a[j] == i)
                    {
                        isSequence = true;
                        break;
                    }

                }
                if (!isSequence)
                    return 0;
                
            }
            return 1;
        }
    }
}
