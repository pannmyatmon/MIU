using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isVesuvian
    {
        /*
         1. A number n isvesuvianif it is the sum of two different pairs of squares.
        For example, 50 is vesuvian because 50 == 25 + 25 and 1 + 49. The numbers 65 (1+64, 16+49) and
        85 (4+81, 36+49) are also vesuvian. 789 of the first 10,000 integers are vesuvian. Write a function namedisVesuvianthat returns 1 if its parameter is a vesuvian number, otherwise it returns 0. 
        Hint: be sure to verify that your function detects that 50 is a vesuvian number!
         */

        public static int isVesuvianCheck(int n)
        {
            int count = 0;
            for (int i = 1; (i * i) < n; i++)
            {
                int sum1 = i * i;
                for (int j = 1; (j * j) < n; j++)
                {
                    int sum2 = j * j;

                    if (sum1 + sum2 == n)
                    {
                        count++;
                        break;
                    }
                }
                if (count >= 2) return 1;
            }
            return 0;
        }
    }
}
