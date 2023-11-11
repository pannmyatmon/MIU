using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    // Qs Set C No.3 page - PG38 
    public static class decodeArray
    {
        // {-1, 0, 1} {0, 1} //  {0, 1, 1, 1, 1, 1, 0, 1}
        // {1}
        public static int decodeArrayCheck(int[] arr)
        {
            String res = "";
            var isNegative = arr[0] < 0;

            int ctr = 0;
            int i = isNegative ? 1 : 0;
            for (; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    res += ctr;
                    ctr = 0;
                    continue;
                }

                ctr++;
            }

            if (isNegative)
                res = "-" + res;

            return Convert.ToInt32(res);
        }

        

    }
}
