using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isCubePowerful
    {
        public static int isCubePowerfulCheck(int n)
        {
            if (n < 0)
                return 0;

            int nCopy = n;
            int sum = 0;

            while (nCopy > 0)
            {
                int digit = nCopy % 10;

                nCopy /= 10;

                int product = 1;

                for (int i = 1; i <= 3; i++)
                {
                    product *= digit;
                }
                sum += product;


            }
            if (sum == n)
                return 1;
            else return 0;
        }
    }
}
