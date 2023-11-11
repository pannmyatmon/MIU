using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isGuthrieSequence
    {// 8, 4, 2, 1
        // 8, 17, 4, 1
        // 8 , 4 , 1
        public static int isGuthrieSequenceCheck(int[] a)
        {
            if (a[a.Length - 1] != 1)
            {
                return 0;
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (a[i] / 2 != a[i + 1])
                        return 0;
                }
                else
                {
                    if (a[i] * 3 + 1 != a[i + 1])
                        return 0;
                }

            }
            return 1;
        }
    }
}
