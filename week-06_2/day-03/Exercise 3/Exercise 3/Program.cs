using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var numberQuery =
                    from number in n
                    where number * number > 20
                    select number;
            foreach (int square in numberQuery)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();

            var numberQueryWithLambda = n.Where(x => (x * x) > 20);
            foreach (int square in numberQueryWithLambda)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();

            foreach (int number in n)
            {
                if (number * number > 20)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
