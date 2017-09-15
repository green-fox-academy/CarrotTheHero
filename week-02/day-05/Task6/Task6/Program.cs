using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write in a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int howmany = input.ToString().Length;
            Console.WriteLine(howmany);
            Console.ReadLine();
        }
    }
}
