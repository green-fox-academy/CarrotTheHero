using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = new int[] { 54, 23, 66, 12 };

            

            foreach (int sum in r)
            {
                sum.Equals(r);
                Console.WriteLine(sum);
            }
            
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            Console.ReadLine();
        }
    }
}