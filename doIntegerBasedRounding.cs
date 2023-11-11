using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class doIntegerBasedRounding
    {
        //int[] a = new int[] { 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(a, 2);

        //int[] b = new int[] { 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(b, 3);
        //System.out.println(Arrays.toString(b));

        //int[] c = new int[] { 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(c, -3);
        //System.out.println(Arrays.toString(c));

        //int[] d = new int[] { -1, -2, -3, -4, -5 };
        //doIntegerBasedRounding(d, 3);
        //System.out.println(Arrays.toString(d));

        //int[] e = new int[] { -18, 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(e, 4);
        //System.out.println(Arrays.toString(e));

        //int[] f = new int[] { 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(f, 5);
        //System.out.println(Arrays.toString(f));

        //int[] g = new int[] { 1, 2, 3, 4, 5 };
        //doIntegerBasedRounding(g, 100);
        //System.out.println(Arrays.toString(g));


        //int[] a = new int[] { 1, 2, 3, 4, 5 };
        public static void doIntegerBasedRound(int[] a, int n)
        {
            if (n > 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    int j = 1;
                    if (a[i] < 0)
                        continue;
                    while (true)
                    {
                        int prev = n * (j - 1);
                        int next = n * j;

                        if (a[i] >= prev && a[i] <= next)
                        {
                            if (a[i] == prev)
                                a[i] = prev;
                            else if (a[i] == next)
                                a[i] = next;
                            else if (a[i] - prev == next - a[i])
                                a[i] = next;
                            else if (a[i] - prev > next - a[i])
                                a[i] = next;
                            else a[i] = prev;

                            break;
                        }
                        j++;
                    }
                }
            }

        }
    }
    
}
