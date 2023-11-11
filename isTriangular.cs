using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isTriangular
    {
       /*
Page - 46 -- Set 2

1. A number n is triangular if n == 1 + 2 +…+j for some j. -- Done
2. Define an array to be a Mercurial array if a 3 does not occur
3. An array is defined to be a 235 array
         // Returns true if 'num' is 
         // triangular, else false
       */
        public static int isTriangularCheck(int num)
            {
                // Base case
                if (num < 0)
                    return 0;

                // A Triangular number must be
                // sum of first n natural numbers
                int sum = 0;

                for (int n = 1; sum <= num; n++)
                {
                    sum = sum + n;
                    if (sum == num)
                        return 1;
                }

                return 0;
            }
        
    }
}
