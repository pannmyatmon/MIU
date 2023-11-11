using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class Centered15
    {
        //int[] a = { 3, 2, 10, 4, 1, 6, 9 }; // 1
        //int[] b = { 2, 10, 4, 1, 6, 9 }; // 0
        public static int Centered15Check(int[] a)
        {
            for (int i = 0; i * 2 < a.Length; i++)
            {
                int sum = 0;
                for (int index = i; index < a.Length - i; index++)
                {
                    sum += a[index];
                }
                if (sum == 15)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}
