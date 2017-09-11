using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.Write("Write down the number of girls: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write down the number of boys: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
                Console.WriteLine("Sausage party");

            else if ((num2 == num1) && (num1 + num2 > 20))
                Console.WriteLine("The party is excellent!");

            else if ((num2 + num1 > 20) && (num1 > num2 || num2 > num1))
                Console.WriteLine("Quite cool party!");

            else if (num2 + num1 < 20)
                Console.WriteLine("Average party...");


            Console.ReadLine();
        }
    }
}