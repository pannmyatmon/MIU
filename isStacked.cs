using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isStacked
    {
        /*1 = 1
          3 = 1 + 2
          6 = 1 + 2 + 3
          10 = 1 + 2 + 3+ 4
          15  = 1 + 2 + 3 + 4 + 5
        7, 8, 9 is not a stack
        */
        public static int isStackedCheck(int n)
        {
            int stackNum = 0;
            int i = 1;
            while (i < n)
            {
                stackNum += i++;
                if (stackNum == n)
                    return 1;
            }
            return 0;
        }
       
    }
}
