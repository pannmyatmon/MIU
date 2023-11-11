using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUI
{
   public static class areAnagrams
    {
        public static int areAnagramsCheck(char[] first, char[] second)
        {
            if (first.Length != second.Length)
                return 0;

            char[] fCopy = new char[first.Length];
            char[] sCopy = new char[second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                fCopy[i] = first[i];
                sCopy[i] = second[i];
            }

            for (int i = 0; i < fCopy.Length; i++) {
                for (int j = 0; j < sCopy.Length; j++)
                {
                    if (fCopy[i] == sCopy[j])
                    {
                        fCopy[i] = ' ';
                        sCopy[j] = ' ';
                    }
                }
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (fCopy[i] != ' ' || sCopy[i] != ' ')
                    return 0;
            }

            return 1;
        }
    }
}
