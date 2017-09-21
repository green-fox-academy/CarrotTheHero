using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string input = "Xaaaxaxxxaaaxaaaxxxxa";
            Console.WriteLine(XtoY(input));
            Console.ReadLine();
        }

        private static string XtoY(string input)
        {
            if (!input.Contains("x"))
                return input;
            else 
            input = XtoY(input.Replace("x", "y"));
            return input;
        }
    }
}
