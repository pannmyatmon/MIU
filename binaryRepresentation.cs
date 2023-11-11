using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
    public static class binaryRepresentation
    {
        public static int[] binaryRepresentationCheck(int n, int _base)
        {
           
            var binary = new List<int>();
            var num = n;
            do
            {
                var rem = num % _base;
                num /= _base;
                binary.Add(rem);
            } while (num > 0);

           
            return binary.ToArray() ;
        }
      
    }
}
