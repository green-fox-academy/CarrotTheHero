using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number to divide 10 with it: ");
            Divider();
            Console.ReadLine();
        }

        private static void Divider()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine (10 / input);
            }
            catch
            {
                Console.WriteLine("You can't divide it by 0");
            }
        }
    }
}
