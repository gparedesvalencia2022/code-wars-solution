using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.Kata._8kyu
{   

    public class KataGetGrade
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            var monList = new List<int>();

            monList.Add(s1);
            monList.Add(s2);
            monList.Add(s3);

            var monAverage = monList.Average();
            var note = 'A';

            if (monAverage >= 90 && monAverage <= 100)
                note = 'A';
            if (monAverage >= 80 && monAverage < 90)
                note = 'B';
            if (monAverage >= 70 && monAverage < 80)
                note = 'C';
            if (monAverage >= 60 && monAverage < 70)
                note = 'D';
            if (monAverage >= 0 && monAverage < 60)
                note = 'F';

            return note;
        }
    }
}
