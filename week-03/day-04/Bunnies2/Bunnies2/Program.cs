using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(Ears(7));
            Console.ReadLine();
        }

        private static int Ears(int rabs)
        {
            if (rabs == 0)
                return 0;
            if (rabs % 2 == 1)
                return 2 + Ears(rabs-1);
            else return 3 + Ears(rabs-1);


        }
    }
}
