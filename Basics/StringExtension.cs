using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    static class StringExtension
    {
        public static string MoveFirstToLast(this string text)
        {
            var firstChar = text[0];
            return text.Substring(1) + firstChar;
        }
    }
}
