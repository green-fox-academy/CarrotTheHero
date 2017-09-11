using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.Write("Number of Chickens: ");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(chicken * 2 + pigs * 4 + "legs");
            Console.ReadLine();
        }
    }
}