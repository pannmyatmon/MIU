using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public  class closestFibonacci_Check
    {

        public  int closestFibonacci(int n)
        {
            if (n < 0)
                return 0;

            var curr = 1;
            var prev = 1;

            while (curr <= n)
            {
                var t = curr;
                curr = prev + curr;
                prev = t;
            }

            return prev;

        }
    }
}
