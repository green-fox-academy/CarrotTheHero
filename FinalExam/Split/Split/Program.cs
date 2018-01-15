using System;
using System.Collections.Generic;
using System.Linq;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Splitter();
            Console.ReadLine();
        }

        private static void Splitter()
        {
            string word = "asd,g,hj,qw,e,wr";
            List<string> Splitted = word.Split(',').ToList();

            foreach (var part in Splitted)
            {
                Console.WriteLine(part);
            }
        }
    }
}