using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isMinMaxDisjoint
    {
        //  {5, 4, 1, 3, 2} => 1
        public static int isMinMaxDisjointCheck(int[] a)
        {
            if (a.Length == 0)
                return 0;

            int max = maxValue(a);
            int min = minValue(a);

           

            //rule a.
            if (max == min)
                return 0;

            //rule c.
            if (countOccurent(a, max) != 1)
                return 0;

            //rule d.
            if (countOccurent(a, min) != 1)
                return 0;

            //rule b.
            int idxMax = indexOf(a, max);
            int idxMin = indexOf(a, min);

           

            if (idxMax - idxMin == 1 || idxMax - idxMin == -1)
                return 0;

            return 1;
                       
        }

        //public static int GetValue(int[] a, bool findMax, out int idx)
        //{
        //    int res = -1;
        //    idx = -1;

        //    int num = a[0];
        //    int inst = 1;
        //    for (int i = 1; i < a.Length; i++)
        //    {
        //        if (finx)

        //    }

        //    return res;
        //}

        public static int indexOf(int[] a, int val)
        {
            int idx = 0;
            for (int i = 0; i < a.Length; i++, idx++)
                if (a[i] == val)
                    break;

            return idx;
        }

        public static int maxValue(int[] a)
        {
            int largestNum = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largestNum)
                {
                    largestNum = a[i];
                }       
            }

            return largestNum ;
        }

        public static int minValue(int[] a)
        {
            int smallestNum = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < smallestNum)
                {
                    smallestNum = a[i];
                }
            }
            return smallestNum;

        }

        public static int countOccurent(int[] a,int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                    count++;
            }
            return count;
        }
     }
}
