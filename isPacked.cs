using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isPacked
    {
        // {4, 4, 4, 4, 1,2, 2, 3, 3, 3}
        // {2, 2, 1, 2, 2} 
        // {}
        // {7, 7, 7, 7, 1,7, 7, 7}
    public static int isPackedCheck(int[] a)
        {
            if (a.Length == 0)
                return 1;

         
            HashSet<int> exist = new HashSet<int>();
            int currentNum = a[0];
            int count = 0;

            exist.Add(currentNum);


            foreach (var i in a)
            {
                if (i == currentNum)
                {
                    count++;
                }
                else if (currentNum != count || exist.Contains(i))
                {
                    return 0;
                }
                else
                {
                    currentNum = i;
                    exist.Add(i);
                    count = 1;
                }
            }
                return 1;
        }
    }
}
