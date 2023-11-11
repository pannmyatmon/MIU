using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isTrivalent
    {
        // {22, 19, 10, 10, 19, 22, 22, 10} -  1
        public static int isTrivalentCheck(int[] a)
        {
            if (a.Length < 3)
                return 0;

            HashSet<int> set = new HashSet<int>();

            foreach (int i in a)
            {
                set.Add(i);
            }
            if(set.Count == 3)
            {
                return 1;  
            }

            return 0;
            
        }
    }
}
