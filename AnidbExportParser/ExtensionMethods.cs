using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {

        public static decimal? ParseAniDbDecimal(this string str)
        {
            decimal k;
            if (decimal.TryParse(str, out k))
            {
                return k;
            }
            return null;
        }

        public static Int32? ParseAniDbInt32(this string str)
        {
            Int32 k;
            if (Int32.TryParse(str, out k))
            {
                return k;
            }
            return null;
        }

        public static DateTime? ParseAniDbDateTime(this string str)
        {
            if (DateTime.TryParseExact(str, "dd.MM.yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var k))
            {
                return k;
            }
            return null;
        }

        public static DateOnly? ParseAniDbDateOnly(this string str)
        {
            DateOnly k;
            if (DateOnly.TryParse(str, out k))
            {
                return k;
            }
            return null;
        }
    }
}
