using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   public static class isSystematicallyIncrease
    {
        // page 41 SetA - No.2
        /*
{1}
{1, 1, 2}
{1, 1, 2, 1, 2, 3}
{1, 1, 2, 1, 2, 3, 1, 2, 3, 4}
{1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5}
{1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6}

        [2:45 pm] Juan Carlos Marcos Estabillo  (NCS)
Console.WriteLine($"input[{idx}] ({input[idx]}) == j ({j})");
         */

        public static int IsSystematicallyIncreasing(int[] input)
        {
            var idx = 0;
            var num = 1;
            // do loop is same with do while and before check condition do once
            do
            {
                for (var j = 1; j <= num; j++)
                {
                    
                    if (input[idx] != j)
                        return 0;

                    idx++;
                }
                num++;
            } while (idx < input.Length);

            return 1;
        }
    }


}
