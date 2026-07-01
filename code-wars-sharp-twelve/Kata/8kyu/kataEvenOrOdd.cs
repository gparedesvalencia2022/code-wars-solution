using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.Kata._8kyu
{
    public class kataEvenOrOdd
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

        }
    }
}

