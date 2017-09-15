using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write down a number to build up the pyramid: ");
            int sum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sum; i++)
            {
                for (int k = 1; k < sum-i+1; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
        }
    }
}