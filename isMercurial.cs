using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Page - 46 -- Set 2

1. A number n is triangular if n == 1 + 2 +…+j for some j. -- Done*
2. Define an array to be a Mercurial array if a 3 does not occur
3. An array is defined to be a 235 array
  
 */
namespace MUI
{
    public static class isMercurial
    {
        //{ 5, 2, 10, 3, 15, 1, 2, 2 };
        public static int IsMercurialCheck(int[] input)
        {
            int idx1 = -1, idx3 = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 1)
                {
                    if (idx1 > -1 && idx1 < idx3 && i > idx3)
                        return 0;

                    idx1 = i;
                }

                if (input[i] == 3)
                    idx3 = i;
            }

            return 1;
        }


    }
}
