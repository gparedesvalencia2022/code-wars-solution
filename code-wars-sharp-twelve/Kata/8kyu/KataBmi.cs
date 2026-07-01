using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.Kata._8kyu
{
    public class KataBmi
    {
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            string taille = "";
            if (bmi <= 30.0)
                taille = "Overweight";
            if (bmi <= 25.0)
                taille = "Normal";
            if (bmi <= 18.5)
                taille = "Underweight";
            if (bmi > 30)
                taille = "Obese";

            return taille;
        }
    }
}
