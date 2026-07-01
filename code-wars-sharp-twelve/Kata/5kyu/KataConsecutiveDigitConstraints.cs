using System;
using System.Numerics;
// 5kyu
namespace code_wars_sharp_twelve.Kata._5kyu
{
    public class KataConsecutiveDigitConstraints
    {
        public static BigInteger NumberOfNumbers(int n)
        {
            if (n == 1) return 9; // 1, 2, 3, 4, 5, 6, 7, 8, 9

            
            BigInteger[,] dp = new BigInteger[10, 10];

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {

                    if (i + j <= 9)
                        dp[i, j] = 1;
                }
            }

            for (int length = 3; length <= n; length++)
            {
                BigInteger[,] nextdp = new BigInteger[10, 10];

                for (int i = 0; i <= 9; i++)
                {

                    for (int j = 0; j <= 9; j++)
                    {

                        for (int k = 0; k <= 9; k++)
                        {

                            if (i + j + k <= 9)
                            {
                                nextdp[j, k] += dp[i, j];

                            }
                        }
                    }
                }
                dp = nextdp;

            }

            BigInteger total = 0;
            for (int i = 0; i <= 9; i++)
            {

                for (int j = 0; j <= 9; j++)
                {
                    total += dp[i, j];

                }

            }
            return total;

        }
    }
}
