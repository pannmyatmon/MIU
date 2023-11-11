using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class countSquarePairs
    {
        // {9} = 0
        // {9, 0, 2, -5, 7} => 2

        // {11, 5, 4, 20} = 3
     
        public static int countSquarePairsCheck(int[] a)
        {
            List<int> list = new List<int>();
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]);
            }
            list.Sort();
            for (int _out = 0; _out < list.Count() - 1; _out++) {

                if (list[_out] < 1)
                {
                    continue;
                }
                for (int _in = _out +1; _in < list.Count(); _in++) {

                    int temp = list[_out] + list[_in];
                    double sqrt = Math.Sqrt(list[_out] + list[_in]);

                    if (sqrt * 10 % 10 == 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }

    }
}
