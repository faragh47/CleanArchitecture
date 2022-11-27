using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public static class UnitConversionExtensions
    {
        public static int KmToMeters(this double distanceKm)
        {
            return (int)(distanceKm * 1000);
        }

        public static double MetersToKm(this int distanceMeters)
        {
            return Convert.ToDouble(distanceMeters) / 1000;
        }

        public static string Sum(List<TimeSpan?> timeSpans)
        {
            TimeSpan? result = new TimeSpan(0);
            foreach (var value in timeSpans)
            {
                if(value is not null)
                result = result + value;
            }
            return result?.TimeToTotalHHMM();
        }

       
    }
}
