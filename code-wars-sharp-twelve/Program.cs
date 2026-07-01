using System;
using code_wars_sharp_twelve.Kata._5kyu;
using code_wars_sharp_twelve.Kata._8kyu;

class Program
{
    static void Main(string[] args)
    {
        List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
        
        var result = KataSumOfK.chooseBestSum(163, 3, ts);

        Console.WriteLine($"the result: {result}");
        Console.ReadLine();
    }
}
