using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class smallest
    {
     //   int a = 4; // 624
     //   int b = 7; // 4762
     //   int c = 6; // 642
        public static int smallestCheck(int n)
        {
            int num = 1;//== 624
          
            while (true)
            {
                bool flag = false;

                for (int i = 1; i <= n; i++)
                {
                    flag = false;
                    int product = num * i;
                    while (product > 0)
                    {
                        int digit = product % 10; 
                        product /= 10; 
                        if (digit == 2)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        break;
                }


                if (flag) 
                    return num;

                num++;
                
            }
           
        }

        private static int DoSmallest(int num)
        {
            for (var i = 1; i <= Int32.MaxValue; i++)
            {
                if (Has2(i))
                {
                    var ctr = 0;
                    for (var j = 1; j <= num; j++)
                    {
                        var t = i * j;

                        if (!Has2(t))
                            break;

                        ctr++;
                    }

                    if (ctr == num)
                        return i;
                }
            }

            return 0;
        }

        private static bool Has2(int num)
        {
            do
            {
                if (num % 10 == 2)
                    return true;

                num /= 10;
            } while (num > 0);

            return false;
        }
       
    }
}
