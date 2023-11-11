using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    /*
     Write a function named sameNumberOfFactors that take two integer arguments and returns 1 
    if they have the same number factors. If either argument is negative, return -1.
    Otherwise return 1.

    SameNumberOfFactors(-6,21)); // -1
    SameNumberOfFactors(6, 21)); //1
    SameNumberOfFactors(8, 12)); // 0
    SameNumberOfFactors(23, 97)); //1
    SameNumberOfFactors(0, 1)); // 0
    SameNumberOfFactors(0, 0)); //1
    
    0*/
    public class sameNumberOfFactors_Check
    {
        public  int SameNumberOfFactors(int n1, int n2)
        {

            if (n1 < 0 || n2 < 0)
                return -1;

            if (n1 == n2)
                return 1;

            if (numberOfFactors(n1) != numberOfFactors(n2))
                return 0;

            return 1;
        }

        private  int numberOfFactors(int n)
        {

            if (n == 0)
                return 0;

            var ctr = 0;
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    ctr++;
            }
            return ctr;

        }
    }
}
