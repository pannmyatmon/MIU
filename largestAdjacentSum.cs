using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class largestAdjacentSum
    {
        // {1, 2, 3, 4} 7 because 3+4 is larger than either 1+2 or 2+3
        //int[] l = { 18, -12, 9, -10 };
        public static int largestAdjacentSumCheck(int[] input)
        {
            int largestSum = input[0] + input[1];
            if (input.Length < 2)
                return 0;
           
            else if (input.Length == 2)
                return largestSum;

            for (int i = 2; i < input.Length; i++)
            {
                largestSum = (largestSum < input[i - 1] + input[i]) ? input[i - 1] + input[i] : largestSum; 
            }
            
            return largestSum;

        }
    }
}
