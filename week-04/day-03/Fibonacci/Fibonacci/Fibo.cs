using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibo
    {
        public double GetNthFibonacciWithFor(int n)
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
            for (int i = 1; i < n; i++)
            {
                nthFibonacci = prevPrev + prev;
                prevPrev = prev;
                prev = nthFibonacci;
            }
            return nthFibonacci;
        }
    }
}
