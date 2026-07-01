using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.Kata._8kyu
{
    public static class KataSummation
    {
        public static int Summation(int num)
        {
            var total = 0;
            if (num == 1)
            {
                return num;
            }
            for (int i = 1; i <= num; i++)
            {

                total += i;

            }
            return total;
        }
    }
}
