using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write("write down a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
                Console.WriteLine("*");

            Console.ReadLine();
        }
    }
}