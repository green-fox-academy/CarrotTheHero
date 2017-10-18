using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Ez A Mondat Lesz Most Az Input";

            var upperCaseQuery = from character in input
                                 where Char.IsUpper(character)
                                 select character;

            foreach (var upperCase in upperCaseQuery)
            {
                Console.WriteLine(upperCase);
            }
            Console.ReadLine();
        }
    }
}
