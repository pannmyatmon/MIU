using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    // qs 40 Set C - 2
    public static class isDigitIncreasing
    {
        /*
         * 7 1 because 7 = 7 (here n is 7)
           36 1 because 36 = 3 + 33
           984 1 because 984 = 8 + 88 + 888

        /**
            * A number is called digit-increasing if it is equal to n + nn + nnn + ... for some digit n between 1 and 9. For example 24 is digit-
            * increasing because it equals 2 + 22 (here n = 2)
            *
            * Write a function called isDigitIncreasing that returns 1 if its argument is digit-increasing otherwise, it returns 0.
         */
        //   int number = 24
         //     int number = 36;
        //        int number = 984;
        //        int number = 7404;
        public static int isDigitIncreasingCheck(int num)
        {
            for (int i = 1; i <= 9; i++)
            {
                int sum = 0;
                int n = i;

                for (int j = 1; j <= 9; j++)
                {
                    sum = sum + n;

                    if (sum == num)
                        return 1;
                }
                   
                if (sum > num)
                {
                    break;


                }
                n = (n * 10) + i;
            }
            return 0;
        }
    }
       
}
