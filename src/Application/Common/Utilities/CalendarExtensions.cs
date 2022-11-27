using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace Common.Utilities
{
    public static class CalendarExtensions
    {
        public static readonly PersianCalendar persianCalendar = new();

        public static int GetPersianYear(this DateTime input)
        {

            var result = 0;

            if (input > persianCalendar.MinSupportedDateTime &&
                input < persianCalendar.MaxSupportedDateTime)
                result = persianCalendar.GetYear(input);

            return result;
        }

        public static int GetPersianMonth(this DateTime input)
        {
            var result = 0;

            if (input > persianCalendar.MinSupportedDateTime &&
                input < persianCalendar.MaxSupportedDateTime)
                result = persianCalendar.GetMonth(input);

            return result;
        }
        public static int GetPersianDay(this DateTime input)
        {
            var result = 0;

            if (input > persianCalendar.MinSupportedDateTime &&
                input < persianCalendar.MaxSupportedDateTime)
                result = persianCalendar.GetDayOfMonth(input);

            return result;
        }

        public static string ConcatTimeAndDate(string time, string DateTime)//modify
        {
            if (DateTime is null) return time;
            var dateTimes = DateTime.Split('-');
            return time = dateTimes[0] + " - " + time;
        }
        //Important:
        //  Get orders from CalTimePart Entity Seed data
        public enum TimPartTypes
        {
            [Display(Name = "دلخواه")]
            Custom,         //0
            [Display(Name = "سال")]
            ASal,           //1

            [Display(Name = "نیم سال اول")]
            BNimSal1,       //2

            [Display(Name = "بهار")]
            Fasl1Bahar,     //3
            [Display(Name = "فروردین")]
            M01Farvardin,   //4 
            [Display(Name = "اردیبهشت")]
            M02Ordibehesht, //5
            [Display(Name = "خرداد")]
            M03Khordad,     //6

            [Display(Name = "تابستان")]
            Fasl2Tabestan,  //7

            [Display(Name = "تیر")]
            M04Tir,         //8
            [Display(Name = "مرداد")]
            M05Mordad,      //9
            [Display(Name = "شهریور")]
            M06Shahrivar,   //10

            [Display(Name = "نیم سال دوم")]
            BNimSal2,       //11

            [Display(Name = "پاییز")]
            Fasl3Paiiz,    //12

            [Display(Name = "مهر")]
            M07Mehr,        //13
            [Display(Name = "آبان")]
            M08Aban,        //14
            [Display(Name = "آذر")]
            M09Azar,        //15

            [Display(Name = "زمستان")]
            Fasl4Zemestan,    //16

            [Display(Name = "دی")]
            M10Dey,         //17
            [Display(Name = "بهمن")]
            M11Bahman,      //18
            [Display(Name = "اسفند")]
            M12Esfand       //19
        }

        public static int GetTimePartStartMonth(this TimPartTypes timePartTypeId)
        {
            var result = 0;
            switch (timePartTypeId)
            {
                case TimPartTypes.ASal:
                    result = 1;
                    break;
                case TimPartTypes.BNimSal1:
                    result = 1;
                    break;
                case TimPartTypes.BNimSal2:
                    result = 7;
                    break;
                case TimPartTypes.Fasl1Bahar:
                    result = 1;
                    break;
                case TimPartTypes.Fasl2Tabestan:
                    result = 4;
                    break;
                case TimPartTypes.Fasl3Paiiz:
                    result = 7;
                    break;
                case TimPartTypes.Fasl4Zemestan:
                    result = 10;
                    break;
                case TimPartTypes.M01Farvardin:
                    result = 1;
                    break;
                case TimPartTypes.M02Ordibehesht:
                    result = 2;
                    break;
                case TimPartTypes.M03Khordad:
                    result = 3;
                    break;
                case TimPartTypes.M04Tir:
                    result = 4;
                    break;
                case TimPartTypes.M05Mordad:
                    result = 5;
                    break;
                case TimPartTypes.M06Shahrivar:
                    result = 6;
                    break;
                case TimPartTypes.M07Mehr:
                    result = 7;
                    break;
                case TimPartTypes.M08Aban:
                    result = 8;
                    break;
                case TimPartTypes.M09Azar:
                    result = 9;
                    break;
                case TimPartTypes.M10Dey:
                    result = 10;
                    break;
                case TimPartTypes.M11Bahman:
                    result = 11;
                    break;
                case TimPartTypes.M12Esfand:
                    result = 12;
                    break;

            }
            return result;
        }
        public static int GetTimePartEndMonth(this TimPartTypes timePartTypeId)
        {
            var result = 0;

            switch (timePartTypeId)
            {
                case TimPartTypes.ASal:
                    result = 12;
                    break;
                case TimPartTypes.BNimSal1:
                    result = 6;
                    break;
                case TimPartTypes.BNimSal2:
                    result = 12;
                    break;
                case TimPartTypes.Fasl1Bahar:
                    result = 3;
                    break;
                case TimPartTypes.Fasl2Tabestan:
                    result = 6;
                    break;
                case TimPartTypes.Fasl3Paiiz:
                    result = 9;
                    break;
                case TimPartTypes.Fasl4Zemestan:
                    result = 12;
                    break;
                case TimPartTypes.M01Farvardin:
                    result = 1;
                    break;
                case TimPartTypes.M02Ordibehesht:
                    result = 2;
                    break;
                case TimPartTypes.M03Khordad:
                    result = 3;
                    break;
                case TimPartTypes.M04Tir:
                    result = 4;
                    break;
                case TimPartTypes.M05Mordad:
                    result = 5;
                    break;
                case TimPartTypes.M06Shahrivar:
                    result = 6;
                    break;
                case TimPartTypes.M07Mehr:
                    result = 7;
                    break;
                case TimPartTypes.M08Aban:
                    result = 8;
                    break;
                case TimPartTypes.M09Azar:
                    result = 9;
                    break;
                case TimPartTypes.M10Dey:
                    result = 10;
                    break;
                case TimPartTypes.M11Bahman:
                    result = 11;
                    break;
                case TimPartTypes.M12Esfand:
                    result = 12;
                    break;

            }

            return result;
        }

        public static DateTime GetTimePartStart(this int persianYear, TimPartTypes timePartTypeId)
        {
            var resultDateTime = persianCalendar.MinSupportedDateTime;
            if (persianYear < persianCalendar.MinSupportedDateTime.Year ||
                persianYear > persianCalendar.MaxSupportedDateTime.Year ||
                timePartTypeId == TimPartTypes.Custom)
            {
                return resultDateTime;
            }

            int monthnumber = GetTimePartStartMonth(timePartTypeId);

            resultDateTime = persianCalendar.ToDateTime(persianYear, monthnumber, 1, 0, 0, 0, 0);

            return resultDateTime;
        }

        public static DateTime GetTimePartEnd(this int persianYear, TimPartTypes timePartTypeId)
        {
            var resultDateTime = persianCalendar.MinSupportedDateTime;
            if (persianYear < persianCalendar.MinSupportedDateTime.Year ||
                persianYear > persianCalendar.MaxSupportedDateTime.Year ||
                timePartTypeId == TimPartTypes.Custom)
            {
                return resultDateTime;
            }

            int monthnumber = GetTimePartEndMonth(timePartTypeId);

            resultDateTime = persianCalendar.ToDateTime(persianYear, monthnumber, persianCalendar.GetDaysInMonth(persianYear, monthnumber), 23, 59, 59, 999);

            return resultDateTime;
        }

        public static DateTime ConvertToGregorianDate(this int persianYear, int persianMonth,
            int persianDay, int hour, int minute, int second, int millisecond)
        {
            var result = persianCalendar.MinSupportedDateTime;
            try
            {
                result = persianCalendar.ToDateTime(persianYear, persianMonth, persianDay, hour, minute, second, millisecond);
            }
            catch (Exception ex)
            {
                //Todo: log exception
                var log = ex.Message;
            }

            return result;
        }

        public static String CreatePersianTimeStamp()
        {
            var nowDateTime = DateTime.Now;
            return $"{nowDateTime.GetPersianYear()}{nowDateTime.GetPersianMonth().ToString().PadLeft(2, '0')}{nowDateTime.GetPersianDay().ToString().PadLeft(2, '0')}T{nowDateTime.Hour.ToString().PadLeft(2, '0')}{nowDateTime.Minute.ToString().PadLeft(2, '0')}{nowDateTime.Second.ToString().PadLeft(2, '0')}{nowDateTime.Millisecond.ToString().PadLeft(3, '0')}";
        }
        public static int GetHour(this string timeStringHHMM)
        {
            int result = 0;
            if (!String.IsNullOrEmpty(timeStringHHMM) && StringExtensions.FormatTimeHHMM(timeStringHHMM).Length == 5)
            {
                try
                {
                    result = Convert.ToInt32(StringExtensions.FormatTimeHHMM(timeStringHHMM).Substring(0, 2));
                }
                catch (Exception ex)
                {
                    var logMessage = ex.Message;
                    throw;
                }
            }
            return result;
        }

        public static int GetMinutes(this string timeStringHHMM)
        {
            int result = 0;
            if (!String.IsNullOrEmpty(timeStringHHMM) && StringExtensions.FormatTimeHHMM(timeStringHHMM).Length == 5)
            {
                try
                {
                    result = Convert.ToInt32(StringExtensions.FormatTimeHHMM(timeStringHHMM).Substring(3, 2));
                }
                catch (Exception ex)
                {
                    var logMessage = ex.Message;
                    throw;
                }
            }
            return result;
        }

        public static string TimeToHHMM(this TimeSpan input)
        {
            return StringExtensions.FormatTimeHHMM($"{input.Hours}:{input.Minutes}");
        }

        public static string TimeToHHMM(this TimeSpan? input)
        {
            if (input is null)
                return "00:00";
            return StringExtensions.FormatTimeHHMM($"{input?.Hours}:{input?.Minutes}");
        }

        public static string TimeToTotalHHMM(this TimeSpan input)
        {
            int Hour = (int)input.TotalHours;
            int Minutes = (int)input.Minutes;

            if (Hour < 0 && Minutes < 0)
                Minutes = Math.Abs(Minutes);

            return StringExtensions.FormatTimeHHMM($"{Hour}:{Minutes}");
        }

        public static TimeSpan ConvertToTime(this long totalSeconds)
        {
            if (totalSeconds < 0)
                totalSeconds = 0;
            return new TimeSpan(totalSeconds * TimeSpan.TicksPerSecond);
        }

        public static TimeSpan ConvertToTimeTrimSeconds(this long totalSeconds)
        {
            if (totalSeconds < 0)
                totalSeconds = 0;
            var temp = new TimeSpan(totalSeconds * TimeSpan.TicksPerSecond);
            return new TimeSpan(temp.Hours, temp.Minutes, 0);
        }

        public static TimeSpan ConvertToTime(this string timeHHMM)
        {
            return new TimeSpan(GetHour(timeHHMM), GetMinutes(timeHHMM), 0);
        }

        public static TimeSpan MinusMinutes(this TimeSpan time, int minutes)
        {
            if (minutes < 0)
                minutes = 0;
            if (minutes > 24 * 60)
                minutes = 24 * 60;
            var temp = new TimeSpan(0, minutes, 0);
            return time - temp;
        }

        public static TimeSpan PlusMinutes(this TimeSpan time, int minutes)
        {
            if (minutes < 0)
                minutes = 0;
            if (minutes > 24 * 60)
                minutes = 24 * 60;
            var temp = new TimeSpan(0, minutes, 0);
            return time + temp;
        }

        public static bool TimeHHMMEquals(this TimeSpan first, TimeSpan second)
        {
            bool result = false;
            first = ConvertToTimeTrimSeconds((long)first.TotalSeconds);
            second = ConvertToTimeTrimSeconds((long)second.TotalSeconds);
            if (first.Hours * 60 + first.Minutes == second.Hours * 60 + second.Minutes)
                result = true;
            return result;
        }

        public static bool IsValidHHMMTime(this string timeHHMM)
        {
            if (String.IsNullOrEmpty(timeHHMM))
                return false;

            if (timeHHMM.Length != 5)
                return false;

            if (timeHHMM.Substring(2, 1) != ":")
                return false;

            var hh = timeHHMM.Substring(0, 2);
            var mm = timeHHMM.Substring(3, 2);
            int h = -1;
            int m = -1;
            if (int.TryParse(hh, out h) == false || int.TryParse(mm, out m) == false)
                return false;

            if (h < 0 || h > 23 || m < 0 || m > 60)
                return false;

            return true;
        }

        public static string DifferenceFromNow(DateTime? dateTime, string exeptionText)
        {
            string str = "";
            var now = DateTime.Now.Date;
            int totalDays = 0;
            if (dateTime is not null)
            {
                totalDays = (int)((DateTime)dateTime - now).TotalDays;
                if (totalDays is 0)
                    str = "اخرین روز";
                else
                    str = (totalDays >= 0 ? totalDays.ToString() + " روز" : exeptionText);
            }
            else
            {
                str = "ثبت نشده";
            }

            return str;
        }
        public static string DifferenceFromNow(DateTime? dateTime)
        {
            return DifferenceFromNow(dateTime, "منقضی شده");
        }

        public static string ToMasfaTimeFormat(string dateTime)
        {
            var date = dateTime.CleanString();

            var datetimeParts = date.Split("-");

            if (datetimeParts.Count() < 1) return null;

            var dateParts = datetimeParts[0].Split("/");

            if (dateParts.Count() != 3)
                return null;

            string[] timeOutput = new string[2]
                { "00", "00"};

            if (datetimeParts.Count() > 1)
            {
                var time = TimeSpan.Parse(datetimeParts[1]).TimeToHHMM();
                timeOutput = time.Split(":");

            }

            var output = dateParts[0] + dateParts[1] + dateParts[2] + timeOutput[0] + timeOutput[1];

            output = output.Replace(" ", "");

            return output;
        }

        public static string MasfaTimeFormatToDateTime(string masfaDateTime)
        {
            var output = "";

            if (!string.IsNullOrEmpty(masfaDateTime))
            {
                var year = masfaDateTime.Substring(0, 4);

                var month = masfaDateTime.Substring(4, 2);

                var day = masfaDateTime.Substring(6, 2);

                var hour = masfaDateTime.Substring(8, 2);

                var minute = masfaDateTime.Substring(10, 2);

                var second = masfaDateTime.Substring(12, 2);
                 output = year + "/" + month + "/" + day + " - " + hour + ":" + minute + ":" + second;
            }

            return output;
        }
        public static string CustomisedTimeSpan(this TimeSpan input)
        {
            int Hour = (int)input.TotalHours;
            int Minutes = (int)input.Minutes;

            if (Hour < 0 && Minutes < 0)
                Minutes = Math.Abs(Minutes);

            return StringExtensions.FormatTimeHHMM($"{Hour}:{Minutes}");
        }
    }
}
