using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[] { 'k', 'a', 'k', 'a', 'o' };

            var letterToWord = String.Join("", letters.Select(letter => letter.ToString()));
            Console.WriteLine(letterToWord);
            Console.ReadLine();
        }
    }
}
