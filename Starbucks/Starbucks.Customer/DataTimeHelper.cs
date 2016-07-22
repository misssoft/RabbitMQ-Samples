using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.Customer
{
    public static class DataTimeHelper
    {
        public static string ConvertToDateTime(string currentTime)
        {
            string[] formats = { "dd/MM/yyyy hh:mm:ss", "MM/dd/yyyy hh:mm:ss" };

            DateTime value;

            string result = currentTime;

            if (DateTime.TryParseExact(currentTime, formats, CultureInfo.InvariantCulture,DateTimeStyles.None, out value))
            {
                result = value.ToDayLightSavingsTime().ToString(CultureInfo.CurrentCulture);
            }

            return result;

        }

       
    }

    public static class DateTimeExtensions
    {
        public static DateTime ToDayLightSavingsTime(this DateTime dateTime)
        {
            return TimeZoneInfo.Local.IsDaylightSavingTime(dateTime) ? dateTime.AddHours(1) : dateTime;
        }
    }
}
