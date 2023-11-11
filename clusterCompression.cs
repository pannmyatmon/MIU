using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class clusterCompression
    {
        public static int[] clusterCompressionCheck(int[] a)
        {
            // int[] a = { 3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4 }; ==>  {3, 4, 3, 2, 4}
            // {18} 
            // {8, 8, 6, 6, -2, -2, -2}

            if (a.Length < 2)
            {
                return a;
            }
            int[] res = new int[] { a[0] };

            foreach (int i in a)
            {
                if (res[res.Length - 1] != i)
                {
                     int[] temp = new int[res.Length + 1];

                    for (int k = 0; k < res.Length; k++)
                    {
                        temp[k] = res[k];
                    }
                    temp[temp.Length - 1] = i;
                    res = temp;
                }
                
            }

            return res;
        }
    }
}
