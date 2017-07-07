using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public static class StringExtension
    {
        /// <summary>
        /// Converts a list of strings to title case.
        /// </summary>
        public static string ConvertToTitleCase(this string source)
        {
            var textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(source);      
        }
    }
}
