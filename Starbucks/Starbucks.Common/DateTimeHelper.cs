using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.Common
{
    public static class DateTimeHelper
    {
        public static string ConvertToDateTime(string currentTime)
        {
            string[] formats = { "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };

            DateTime value;

            string result = currentTime;

            if (DateTime.TryParseExact(currentTime, formats, CultureInfo.InvariantCulture,DateTimeStyles.None, out value))
            {
                result = value.ToDayLightSavingsTime().ToString(CultureInfo.CurrentCulture);
            }

            return result;

        }
    }
}
