using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   public static class stantonMeasure
    {// 3,1,1,4
        // {1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4}
        public static int stantonMeasureCheck(int[] a)
        {
           
                int count1 = 0;
                int result = 0;
                foreach (int i in a) {
                if (i == 1)
                {
                    count1++;
                }
            }
            foreach (int i in a)
            {
                if (i == count1)
                {
                    result++;
                }
            }
            return result;
        
      }
    }
}
