using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class MadhavArray
    {
        //int[] A = { 2, 1, 1, 4, -1, -1 , 1 };

 
        public static int IsMadhavArray(int[] a)
        {
                if (a.Length <= 0)
                    return 0;

            ////check for correct array length

            //int x = a.Length * 2;

            //int n = (int)Math.Sqrt(x);

            //if (n * (n + 1) != x)

            //    return 0;

            int n = 2;
            bool isCorrectLength = false;

            while (n * (n + 1) <= 2 * a.Length)
            {
                if (n * (n + 1) == 2 * a.Length)
                {
                    isCorrectLength = true;
                    break;
                }
                else
                {
                    n++;
                }
            }
            if (!isCorrectLength)
            {
                return 0;
            }

            // {2, 1, 1, 4, -1, -1} => 1
            // a[0] = a[1] + a[2] = a[3] + a[4] + a[5] = a[6] + a[7] + a[8] + a[9] = a[10] + a[11] + a[12] + a[13] + a[14] = ...

                int num = a[0];
                int ctr = 2;

                for (int i = 1; i < a.Length;)
                {
                    int temp = 0;
                    for (int j = 1; j <= ctr; j++)
                    {
                        if (i >= a.Length)
                            return 0;

                        temp += a[i];
                        i++;
                    }

                    if (num != temp)
                        return 0;

                    ctr++;
                }

                return 1;

            }

            public static int MadhavArrayCheck(int[] a) // 6
           {

            int n = 2;
            bool isCorrectLength = false;

            while (n * (n + 1) <= 2 * a.Length)
            {
                if (n * (n + 1) == 2 * a.Length)
                {
                    isCorrectLength = true;
                    break;
                }
                else
                {
                    n++;
                }
            }
            if (!isCorrectLength)
            {
                return 0;
            }
            int num = 2;
            for (int i = 1; i < a.Length;)
            {
                int sum = 0;
                for (int j = i; j < i + num; j++)
                {
                    sum += a[j];
                }
                if (sum != a[0])
                {
                    return 0;
                }
                i += num++;
            }
            return 1;
        }
    }
}
