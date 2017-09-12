using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter

            int num = 42;
            Console.WriteLine(Sum(num));
            Console.ReadLine();

        }

        public static int Sum(int input)
        {
            for (int i = input; i > 0; i--)
            {
                input += i - 1;
            }
            return input;

        }
    }
}