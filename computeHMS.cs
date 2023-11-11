using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Page - 46 - 
=========
computeHMS - Set 1
1.computeHMS int[] computeHMS(int seconds);
2.Martian array -> int isMartian(int[ ] a)  === Done*
3.paired-N -> int isPairedN(int[ ] a, int n) - . Once you know the array is paired-N, you should return 1. No wasted loop iterations please.

   */
namespace MUI
{
    public static class computeHMS
    {
        public static int[]  computerHMSCal(int seconds)
        {
            int[] hms = new int[3];

            int h = 0;
            int m = 0;
            int s = 0;

            h = seconds / 3600;
            s = seconds % 3600;
            hms[0] = h; 

            m = seconds / 60;
            s = seconds % 60;
            hms[1] = m;

            s = seconds;
            hms[2] = s;



            return hms;



            
        }
    }
}
