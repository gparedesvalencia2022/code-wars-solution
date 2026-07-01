using System;
using System.Collections.Generic;
using System.Text;

namespace code_wars_sharp_twelve.DomeCode
{
    using System;
    using System.Collections.Generic;

    public class DateTransform
    {
        public static List<string> TransformDateFormat(List<string> dates)
        {
            var transformedDates = new List<string>();
            var fnalDate = string.Empty;

            foreach (string date in dates)
            {
                if(date.Contains("/"))
                {
                    string[] parts = date.Split('/');
                    if (parts[0].Length == 4)
                    {
                        // Formato YYYYMMDD
                        fnalDate = parts[0]+parts[1]+parts[2];
                        transformedDates.Add(fnalDate);
                    }
                    else if(parts[2].Length == 4)
                    {
                        fnalDate = parts[2] + parts[1] + parts[0];
                        transformedDates.Add(fnalDate);
                    }
                }
                else if (date.Contains("-"))
                {
                    string[] parts = date.Split('-');
                    if (parts[0].Length == 4)
                    {
                        // Formato YYYYMMDD
                        fnalDate = parts[0] + parts[1] + parts[2];
                        transformedDates.Add(fnalDate);
                    }
                    else if (parts[2].Length == 4)
                    {
                        fnalDate = parts[2] + parts[1] + parts[0];
                        transformedDates.Add(fnalDate);
                    }
                }
                else if (date.Length == 8)
                {
                    // Formato YYYYMMDD
                    transformedDates.Add(date);
                }

                
            }
            return transformedDates;
        }
        

        //public static void Main(string[] args)
        //{
        //    var input = new List<string> { "2010/02/20", "19/12/2016", "11-18-2012", "20130720" };
        //    DateTransform.TransformDateFormat(input).ForEach(Console.WriteLine);
        //}
    }
}
