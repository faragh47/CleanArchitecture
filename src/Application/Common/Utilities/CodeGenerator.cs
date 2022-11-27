using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public class CodeGenerator
    {
        public static string CreateCodeWithDate<T>(T Id, DateTime DateTime)
        {
            var date = CalendarExtensions.GetPersianYear(DateTime).ToString("D2") +
                CalendarExtensions.GetPersianMonth(DateTime).ToString("D2") +
                CalendarExtensions.GetPersianDay(DateTime).ToString("D2");

            var output = date + "-" + Id.ToString();

            return output;
        }

    }
}
