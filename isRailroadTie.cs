using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isRailroadTie
    {
        // {1, 2, 0, 1, 2, 0, 1, 2}  => 1

        // {1, 3, 0, 3, 5, 0} => 0

        // {1, 2}
        public static int isRailroadTieCheck(int[] a)
        {
            int countZeros = 1;
            int len = a.Length;

            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    if (a[i + 1] == 0)
                        return 0;
                }
                else if (i == len - 1)
                {
                    if (a[i] == 0)
                        return 0;

                }
                else
                {
                    if (i != 0)
                    {
                        
                        if (a[i - 1] != 0 && a[i + 1] != 0)
                        {
                            return 0;
                        }
                        else if (a[i - 1] == 0 && a[i + 1] == 0)
                        {
                            return 0;
                        }
                        else
                        {
                           if(a[i] == 0)
                            countZeros++;

                            if ((a[i - 1] != 0 && a[i + 1] != 0))
                                return 0;
                        }
                    }
                }
            }
            if (countZeros == len)
                return 0;
            return 1;

        }
    }
}
