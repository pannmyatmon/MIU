using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isVanilla
    {

        public static int isVanillaCheck(int[] a)
        {
            //int[] a = { 1, 1, 11, 1111, 1111111 };  // 1
            //int[] b = { 11, 101, 1111, 11111 };   // 0
            //int[] c = { 1 }; // 1
            //int[] d = { 11, 22, 13, 34, 125 }; // 0 
            //int[] e = { 9, 999, 99999, -9999 }; // 1
            //int[] f = { }; // 1
            if (a.Length == 0)
            {
                return 1;
            }
            int digit = a[0] % 10 < 0 ? 0 - a[0] % 10 : a[0] % 10;

            foreach(int i in a)
            {
             int   j = i < 0 ? 0 - i : i;
                while (j != 0)
                {
                    if (j % 10 != digit)
                    {
                        return 0;
                    }
                    j /= 10;
                }
            }
            return 1;
        }

    }
    
}
