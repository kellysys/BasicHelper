using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHelper.Extentions
{
    public static class StringExtentions
    {
        public static string ReverseBitString(this string text)
        {
            if (text == null) return string.Empty;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
