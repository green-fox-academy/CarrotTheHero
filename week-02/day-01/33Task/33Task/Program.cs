using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int num = 8;
            int input = 0;

            Console.Write("Guess my number: ");

            while (num != input)
            {
               
             input = Convert.ToInt32(Console.ReadLine());

                if (input < num)
                    Console.WriteLine("The stored number is higher");

                else if (input > num)
                    Console.WriteLine("The stored number is lower");
            }

            Console.WriteLine("You foun the number: " + num);
            Console.ReadLine();
        }
    }
}