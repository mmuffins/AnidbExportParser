using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DateTime k;
            if (DateTime.TryParse(str, out k))
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
