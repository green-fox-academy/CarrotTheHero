using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringagainagain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            Console.WriteLine(Stringwithstar("sajtosborso"));
            Console.ReadLine();

        }

        private static string Stringwithstar(string input)
        {
            if (input.Length == 1) return input;

            return input[0] + "*" + Stringwithstar(input.Substring(1));
        }
    }
}
