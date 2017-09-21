using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).            
            Console.WriteLine(Bunnyears(42));
            Console.ReadLine();
        }

        private static int Bunnyears(int bunnies)
        {
            if (bunnies == 0)
                return 0;
            return 2 + Bunnyears(bunnies -1);

        }
    }
}
