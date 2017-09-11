using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fifth number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("Sum is: " + sum);

            double ave = (num1 + num2 + num3 + num4 + num5) / 4.0;
            Console.WriteLine("Average is: " + ave);

            Console.ReadLine();
        }
    }
}