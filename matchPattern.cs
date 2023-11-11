using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class matchPattern
    {

        public static int matchesP(int[] a, int[] p)
        {
            //int index = 0;
            //for (int i = 0; i < p.Length; i++)
            //{
            //    int temp = p[i] < 0 ? -p[i] : p[i];
            //    for (int j = 0; j < temp; j++)
            //    {
            //        if ((p[i] > 0 && a[index] < 0) || (p[i] < 0 && a[index] > 0))
            //        {
            //            return 0;
            //        }

            //        index++;
            //    }
            //}
            return 1;
        }
        public static int matchPatternCheck(int[] a, int[] pattern)
        {
            // {1, 1, 1, 1, 1} {1} ==> 1
            // {1, 1, 1, 1, 2, 2, 3, 3} {1, 2}  ==> 0
            // a = {1, 1, 1, 2, 2, 1, 1, 3} , b = {1, 2, 1, 3} => 1
            //int[] a1 = { 1, 1, 1, 1, 2, 2, 3, 3 };
            //int[] b1 = { 1, 2 };

            // len is the number of elements in the array a, patternLen is the number of elements in the pattern.
            int len = a.Length;
            int patternLen = pattern.Length;
            int i = 0; // index into a
            int k = 0; // index into pattern
            int matches = 0; // how many times current pattern character has been matched so far
            int nextMatches = 0;

            for (i = 0; i < len; i++)
            {
                if (a[i] == pattern[k])
                    matches++; // current pattern character was matched

                else if (matches == 0 || k == patternLen - 1)
                    return 0; // if pattern[k] was never matched (matches==0) or at end of pattern (k==patternLen-1)

                else // advance to next pattern character 
                {
                    //  !!You write this code!!

                    k++;
                    if (a[i] == pattern[k])
                        matches++;
                    else
                        return 0;
                } // end of else
            } // end of for
            // return 1 if at end of array a (i==len) and also at end of pattern (k==patternLen-1)
            if (i == len && k == patternLen - 1)
                return 1;
            else return 0;
        }

        }
    }

