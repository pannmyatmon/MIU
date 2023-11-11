using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class Base10
    {
        public static void Run()
        {
           


            Run(new int[] { 1, 0, 1, 1 }, 2);
            Run(new int[] { 1, 1, 2 }, 3);
            Run(new int[] { 3, 2, 5 }, 8);
            Run(new int[] { 3, 7, 1 }, 6);





        }



        public static void Run(int[] input, int @base) =>
            Console.WriteLine($"[Legal: { IsLegalBase(input, @base) }] input: { string.Join("", input) }, {@base} = { ConvertToBase10(input, @base) }");



        private static int ConvertToBase10(int[] input, int baseNum)
        {
            if (!IsLegalBase(input, baseNum))
                return 0;



            var len = input.Length - 1;
            var result = 0;
            for (var i = 0; i <= len; i++)
                result += input[len - i] * Pow(baseNum, i);
            return result;
        }
        private static bool IsLegalBase(int[] input, int baseNum)
        {
            //foreach (var i in Enumerable.Range(0, input.Length))
            //    if (input[i] > @base)
            //        return false;

            //return true;
            bool _ans = true;
            foreach (var i in input)
            {
                if (input[i] > baseNum)
                    return false;
                return true;
                
            }
            return _ans;
        }



        private static int Pow(int baseNum, int exp)
        {
            if (exp == 0)
                return 1;



            var result = baseNum;
            //foreach (var i in Enumerable.Range(1, exp - 1))
            //    result *= baseNum;

            for (int i = 0; i < exp; i++)
            {
                // result = result * baseNum;
                result *= baseNum;
            }
            



            return result;
        }
    }

  
}
