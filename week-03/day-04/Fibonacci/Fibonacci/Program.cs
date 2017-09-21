using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // The fibonacci sequence is a famous bit of mathematics, and it happens to
            // have a recursive definition. The first two values in the sequence are
            // 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
            // previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
            // and so on. Define a recursive fibonacci(n) method that returns the nth
            // fibonacci number, with n=0 representing the start of the sequence.

            Console.WriteLine(GetNthFibonacciWithFor(9));
            Console.ReadLine();
        }

        private static double GetNthFibonacciWithFor(int n)
        {
            double nthFibonacci = 0;
            if (n == 2)
            {
                nthFibonacci = 1;
            }
            if (n <= 2)
            {
                return nthFibonacci;
            }

            double prevPrev = 0;
            double prev = 1;
            for (int i = 1; i < n - 1; i++)
            {
                nthFibonacci = prevPrev + prev;
                prevPrev = prev;
                prev = nthFibonacci;
            }
            return nthFibonacci;
        }
    }
}
