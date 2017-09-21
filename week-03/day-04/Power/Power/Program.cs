using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(Power(2, 10));
            Console.ReadLine();
        }

        private static int Power(int stock, int pow)
        {
            if (pow < 1)
                return 1;
            else if (stock < 1)
                return 0;
            stock *= Power(stock, pow - 1);
            return stock;
        }
    }
}
