using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public static class PersianDateExtensions
    {
        public static string ToPersianDate(this DateTime? dateTime)
        {
            if (dateTime is null)
                return null;

            var date = dateTime ?? DateTime.Now;

            PersianCalendar pc = new PersianCalendar();

            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
        }


        public static string ToPersianDate(this DateTime dateTime)
        {
            var date = dateTime;
            string output = "";

            PersianCalendar pc = new PersianCalendar();

            if (date > pc.MinSupportedDateTime &&
            date < pc.MaxSupportedDateTime)
                output = $"{pc.GetYear(date)}/{pc.GetMonth(date).ToString().PadLeft(2, '0')}/{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

            return output;
        }



        public static string ToPersianLongDate(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }
            var date = (DateTime)dateTime;

            string output = "";

            PersianCalendar pc = new PersianCalendar();

            if (date > pc.MinSupportedDateTime &&
            date < pc.MaxSupportedDateTime)
                output = $"{pc.GetYear(date)}/{pc.GetMonth(date).ToString().PadLeft(2, '0')}/{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')} " +
                $"- {pc.GetHour(date).ToString().PadLeft(2, '0')}:{pc.GetMinute(date).ToString().PadLeft(2, '0')}";

            return output;
        }

        public static string ToPersianLongDate(this DateTime dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }
            var date = (DateTime)dateTime;

            string output = "";

            PersianCalendar pc = new PersianCalendar();

            if (date > pc.MinSupportedDateTime &&
            date < pc.MaxSupportedDateTime)
                output = $"{pc.GetYear(date)}/{pc.GetMonth(date).ToString().PadLeft(2, '0')}/{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')} " +
                $"- {pc.GetHour(date).ToString().PadLeft(2, '0')}:{pc.GetMinute(date).ToString().PadLeft(2, '0')}";

            return output;
        }

        public static string ToPersianTime(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }
            var date = (DateTime)dateTime;

            string output = "";

            PersianCalendar pc = new PersianCalendar();

            if (date > pc.MinSupportedDateTime &&
            date < pc.MaxSupportedDateTime)
                output = $"{pc.GetHour(date).ToString().PadLeft(2, '0')}:{pc.GetMinute(date).ToString().PadLeft(2, '0')}";

            return output;
        }


        public static DateTime? ToGregorianDate(this DateTime? date)
        {
            if (date == null)
            {
                return null;
            }
            try
            {
                PersianCalendar pc = new PersianCalendar();

                DateTime dt = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, pc);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static DateTime? ToGregorianDate(this string date)
        {
            if (String.IsNullOrEmpty(date))
            {
                return null;
            }
            try
            {
                date = date.CleanString();

                var dateParts = date.Split("/");
                if (dateParts.Count() != 3)
                    return null;

                PersianCalendar pc = new PersianCalendar();

                DateTime dt = new DateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]), pc);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static DateTime? ToGregorianDateTime(this string date,string spliter="-")
        {
            if (String.IsNullOrEmpty(date))
            {
                return null;
            }
            try
            {
                date = date.CleanString();

                var datetimeParts = date.Split(spliter);

                if (datetimeParts.Count() < 1) return null;

                var dateParts = datetimeParts[0].Split("/");

                if (dateParts.Count() != 3)
                    return null;

                TimeSpan time = new TimeSpan();

                if (datetimeParts.Count() > 1)
                {
                    time = TimeSpan.Parse(datetimeParts[1]);
                }

                PersianCalendar pc = new PersianCalendar();

                DateTime dt = new DateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]),
                    time.Hours, time.Minutes, time.Seconds, pc);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }




        public static string ToOracleDate(this DateTime date)
        {
            try
            {
                return string.Concat(date.Year, "-", date.Month, "-", date.Day);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
