using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace code_wars_sharp_twelve.Kata._7kyu
{
    public class KataGettingLINQ
    {
        public static int Sum(int[] integers)
        {
            var sum = integers.Sum();
            
            return sum;
        }

        public static int CountChar(char[] chars, char charToCount)
        {
           
           return chars.Where(c => c == charToCount).Count();
            
        }

        public static int[] CalculateSquares(int start, int end)
        {
            List<int> squares = new List<int>();

            return Enumerable.Range(start, end - start + 1).Select(x => x * x).ToArray();            
        }
    }
}
