using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "chilisbab";

            var findTheNumberofLetters = input.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var letters in findTheNumberofLetters)
            {
                Console.WriteLine(letters);
            }
            Console.ReadLine();
        }
    }
}

