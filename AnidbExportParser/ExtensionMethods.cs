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
            if (str.Equals("-"))
            {
                return null;
            }
                
            decimal k;
            if (decimal.TryParse(str, out k))
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
