using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniChar
{
    public class UniChars
    {
        public static char[] Chars(string inputWord)
        {
            return inputWord.Replace(" ", "").ToLower().Distinct().ToArray();
        }
    }
}
