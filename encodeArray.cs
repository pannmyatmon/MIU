using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    // qs 41 Set B - 3
    public static class encodeArray
    {
        // 1 / {0, 1}
        // int n = -201;

        //  Console.WriteLine("encodeArray :" +string.Join(',', encodeArray.DoEncodedArray(n)));


        public static int[] DoEncodedArray(int num)
        {
            var isNegative = num < 0;
            var numAbs = isNegative ? -num : num;
            var sNum = numAbs.ToString();

            var result = new List<int>();

            if (isNegative)
                result.Add(-1);

            foreach (var s in sNum)
            {
                var sint = Convert.ToInt32(s.ToString());

                if (sint != 0)
                    result.AddRange(Enumerable.Range(1, sint).Select(i => 0));

                result.Add(1);
            }

            return result.ToArray();
        }
     
    }
    
}
