using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.Kata._8kyu
{    public static class KataReverseSeq
    {
        public static int[] ReverseSeq(int n)
        {
            int[] monarray = new int[n];
            monarray[0] = n;
            var limite = n;
            for (int i = 1; i < n; i++)
            {

                monarray[i] = limite - 1;
                limite = limite - 1;
            }
            return monarray;
        }
    }
}
