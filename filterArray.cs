using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class filterArray
    {
        // {9, -9} 0 {}
        // {0, 9, 12, 18, -6} 11 {0, 9, 18}
        // {8, 4, 9, 0, 3, 1, 2} / 88
        //   int[] a = { 8, 4, 9, 0, 3, 1, 2 }; // 0,3,2 binary = 0,0,0,1,1,0,1
        //  int n = 88;

        public static int[] DoFilterArray(int[] a, int n)
        {
            //1. get binary of n
            var binary = new List<int>();
            var num = n;
            do
            {
                var rem = num % 2;
                num /= 2;
                binary.Add(rem);
            } while (num > 0);

            //2. count 1s from binary to init result array
            var ctr = 0;
            foreach (var b in binary)
                if (b == 1)
                    ctr++;

            //if no 1s in binary; return empty array
            if (ctr <= 0)
                return new int[] { };

            var result = new int[ctr];
            var idx = 0;
            for (var i = 0; i < binary.Count; i++)
                if (binary[i] == 1) //  0,0,0,1,1,0,1
                {
                    if (i > a.Length - 1)
                        return null;

                    result[idx] = a[i];
                    idx++;
                }

            return result;
        }
     
        public static int[] filterArrayCheck(int[] a, int n)
        {
            int indexcount = 0;
            int digitindex = 0;

            int[] temp = new int[a.Length]; // 7
            do
            {
                int ldigit = n % 2; // 
                if (ldigit == 1)
                {
                    temp[indexcount] = digitindex; // 11/2 = 1
                    indexcount++; // 1 +1 + 1
                }
                n = n / 2; // 44/2 = 22 (1 count)  , 22 / 2 = 11, 11/ 2 = 5, 2/2 =1
                digitindex++; // 1 + 1 + 1 +1 + 1 + 1 + 1
            } while (n > 0);

            int[] filterarray = new int[indexcount]; //4
            for (int i = 0; i < indexcount; i++)
            {
                int index = temp[i];
                if (index > a.Length - 1) 
                    return null;
                filterarray[i] = a[index];

            }

            return filterarray;


        }
    }
}
