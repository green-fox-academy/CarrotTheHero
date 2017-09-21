using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(AddNumber(10));
            Console.ReadLine();
        }

        private static int AddNumber(int n)
        {
            if (n == 0)
                return 0;
            n += AddNumber(n - 1);
            return n;
        }
    }
}
