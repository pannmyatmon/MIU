using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class is121Array
    {
        //
        //int[] a = { 1, 2, 1 };
        // {1, 1, 2, 2, 2, 1, 1}
        // {1, 1, 1, 2, 2, 2, 1, 1, 1,3};
        public static int is121ArrayCheck(int[] a)
        {

            if (a.Length < 3)
            {
                return 0;
            }
            int countBegin1 = 0;
            int countEnd1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    countBegin1++;
                }
                else
                {
                    break;
                }
            }
            for (int i = a.Length - countBegin1; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    countEnd1++;
                }
            }
            if (countBegin1 != countEnd1 || countBegin1 == a.Length || countBegin1 == 0)
            {
                return 0;
            }
            for (int i = countBegin1; i < a.Length - countBegin1; i++)
            {
                if (a[i] != 2)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
    }

