﻿using System.Linq;

namespace Core.Lib.ServiceProxy
{

    public static class StringFormatHelper
    {
        public static string FormatBy(this string str,params string[] formats)
            => formats.Aggregate(str,(seed,next) => string.Format(next, seed));
    }
}
