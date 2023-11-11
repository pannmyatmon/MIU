using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class matches
    {
        //A = {1, 2, 3, -5, -5, 2, 3, 18}
       // If P = { 3, -2, 3 }
        public static int simplePatternMatch(int[] A, int[] P)
        {
            var Ptotal = 0;

            for (int i = 0; i < P.Length; i++)
            
                Ptotal += P[i] < 0 ? -P[i] : P[i];

            if (A.Length != Ptotal)
                return 0;


            var curr = 0;
            // pAbs = 3 // A = {1, 2, 3, -5, -5, 2, 3, 18}
            // If P = { 3, -2, 3 }

            for (var p = 0; p < P.Length; p++)
            {
                var pVal = P[p];
                var pAbs = pVal < 0 ? -pVal : pVal;
                var isNegative = pVal < 0;

              
                for (var a = 0; a < pAbs; a++)
                {
                    //if (isNegative != (A[a] < 0))
                    //    return 0;

                    if (isNegative)
                    {
                        if (A[curr] > 0)
                            return 0;
                    }
                    else
                    {
                        if (A[curr] < 0)
                            return 0;
                    }


                    curr++;
                }
            }



            return 1;
        }
    }
}
