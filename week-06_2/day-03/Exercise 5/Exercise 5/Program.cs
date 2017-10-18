using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var findTheNumberofNumbers = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var numbers in findTheNumberofNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}
