using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isolated
    {
        // 163
        // 162
        public static int isolatedCheck(long n)
        {
            if ( n > 2097151)
            return -1;

            long squaredOfN = n * n; //26569  / 4,761
            long cubeOfN = squaredOfN * n; // 4330747 // 328,509

            while (cubeOfN != 0)
            {
                var t = squaredOfN; // 0
                do
                {
                    if (cubeOfN % 10 == t % 10) //  7 = 9
                       
                        return 0;

                    t /= 10;
                } while (t > 0);

                cubeOfN /= 10;
            }
            return 1;
        }
    }
}
