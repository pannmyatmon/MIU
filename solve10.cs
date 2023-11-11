using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MUI
{
    public static class solve10
    {
        public static int[] solve10Check()
        {
            int factorialX = 1;
            int factorialY = 1;
            int x = 1;
            int y = 1;
            bool matched = false;
            int tenFactorial = 1;
            int[] result = new int[2];

            for (int i = 1; i <= 10; i++)
            {
                tenFactorial *= i;
            }

            for (x = 1; x <= 10 && !matched; x++)
            {
                factorialX *= x;
                factorialY = 1;
                for (y = 1; y <= 10 && !matched; y++)
                {
                    factorialY *= y;
                    if (tenFactorial == factorialX + factorialY)
                    {
                        matched = true;
                        break;
                    }
                }
            }

            if (matched)
            {
                result[0] = x;
                result[1] = y;
            }
            else
                return new int[] { };
           

            return result;
        }
            public static int[] solve10Check1()
        {
            int[] ans = new int[2];
            int y = 0;
            int target = factorial(10);

            foreach (int x in Enumerable.Range(1, 10))
            {

                int y_factorial = target - factorial(x);
               


                // Calculate y by checking if y! is equal to y_factorial
                while (factorial(y) < y_factorial)
                    y += 1;


                if (factorial(y) == y_factorial)
                {

                    ans[0] = x;
                    ans[1] = y;
                    return ans;
                }

            }
            return ans;

        }

        private static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

    }
    } 

