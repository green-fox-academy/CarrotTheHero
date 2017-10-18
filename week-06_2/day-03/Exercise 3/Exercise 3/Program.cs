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

            IEnumerable<int> scoreQuery =
                    from number in n
                    where number > 0
                    select number * number;
            foreach (int square in scoreQuery)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }
    }
}
