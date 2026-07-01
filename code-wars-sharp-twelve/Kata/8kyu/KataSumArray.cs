
namespace code_wars_sharp_twelve.Kata._8kyu
{
    public class KataSumArray
    {
        public static double SumArray(double[] array)
        {
            if (array == null)
                return 0;

            var longeur = array.Length;
            double sum = 0.0;

            for (int i = 0; i < longeur; i++)
            {

                sum += array[i];

            }

            return sum;
        }
    }
}
