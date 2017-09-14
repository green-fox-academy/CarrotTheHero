using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write in a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write in as many numbers as you said before: ");
            int secnum = 0;

            for (int i = 0; i < num; i++)
            {
                secnum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sum: " + secnum + ", Average: " + (secnum / num));
            Console.ReadLine();
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}