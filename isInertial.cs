using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MUI
{
    public static class isInertial
    {
        public static int isInertialCheck(int[] A)
        {
            var odd = new List<int>();
            var even = new List<int>();

            foreach (var i in A)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            //rule 1. must have 1 odd number
            if (odd.Count <= 0)
                return 0;

            //rule 2. max value must be even
            List<int>  newA = A.ToList();
            newA.Sort();
            //var newA = A.ToList().OrderBy(a => a);

            var max = newA[newA.Count - 1];
            if (max % 2 != 0)
                return 0;

            //rule 3. odd must be greater than even except max value
            foreach (var o in odd)
                foreach (var e in even)
                {
                    if (e == max)
                        continue;

                    if (e > o)
                        return 0;
                }

            return 1;
        }


    }
}
