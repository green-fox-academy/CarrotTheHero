using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.Write("Write down a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write down another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("First number is bigger");

            else if (num2 > num1)
                Console.WriteLine("Second number is bigger");

            else
                Console.WriteLine("Numbers are equal");

            Console.ReadLine();

                
        }
    }
}