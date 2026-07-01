using System;
//8kyu
namespace code_wars_sharp_twelve.Kata._8kyu
{
    public class KataFindNeedle
    {
        public static string FindNeedle(object[] haystack)
        {
            int limit = haystack.Length;
            int vIndex = 0;

            for (int i = 0; i < limit; i++)
            {
                if (haystack[i] != null && haystack[i].ToString() == "needle")
                { vIndex = i; }


            }
            return "found the needle at position " + vIndex;
        }
    }
}