using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenNumber = n.Where(y => y % 2 == 0);

            foreach (int evenNum in evenNumber)
            {
                Console.WriteLine(evenNum);
            }

            Console.ReadLine();
        }
    }
}
