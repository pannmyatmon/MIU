using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class isSumSafe
    {
        //a = {5, -5, 0}
        //b = {5, -2, 1} 
        public static int isSumSafeCheck(int[] arr)
        {
            int sum = 0;

            List<int> newArr = new List<int>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                newArr.Add(arr[i]);
            }

            if (newArr.Contains(sum))
            {
                return 0;
            }
            return 1;


        }
    }
}
