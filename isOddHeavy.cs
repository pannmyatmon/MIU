using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isOddHeavy
    {
        // {11, 4, 9, 2, 8}  => 1
        // {2, 4, 6, 8, 11}  => 1
        // {-2, -4, -6, -8, -11} => 0
    public static int isOddHeavyCheck(int[] a)
        {
            bool oddFlag = false;

            int smallestOdd = Int32.MaxValue;
            int largestEven = Int32.MinValue;

            foreach(var ans in a)
            {
                if (ans % 2 != 0)
                {
                    oddFlag = true;
                    if (ans < smallestOdd)
                        smallestOdd = ans;
                }
                else
                {
                    if (ans > largestEven)
                        largestEven = ans;
                }
            }
            if (oddFlag && smallestOdd > largestEven)
                return 1;
            else 

            return 0;
        }
    }
}
