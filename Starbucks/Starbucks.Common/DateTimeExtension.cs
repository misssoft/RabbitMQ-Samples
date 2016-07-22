using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.Common
{
    public static class DateTimeExtensions
    {
        public static DateTime ToDayLightSavingsTime(this DateTime dateTime)
        {
            return TimeZoneInfo.Local.IsDaylightSavingTime(dateTime) ? dateTime.AddHours(1) : dateTime;
        }
    }
}
