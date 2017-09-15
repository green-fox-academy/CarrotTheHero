using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write in a word: ");
            string s1 = Console.ReadLine();

            Console.Write("Write in a second word to check if it's an anagram: ");
            string s2 = Console.ReadLine();

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not the same length");
            }
            else
            {
                string ss = String.Concat(s1.OrderBy(c => c));
                string zz = String.Concat(s2.OrderBy(c => c));

                if (ss == zz)
                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
