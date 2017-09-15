using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a word: ");
            string input = Console.ReadLine();
            Console.WriteLine(input + CreatPalindrome(input));
            Console.ReadLine();
        }

        private static string CreatPalindrome(string input)
        {
            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
        }
    }
}
