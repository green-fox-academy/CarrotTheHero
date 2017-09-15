using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write down how many number should be in the game: ");
            int innum = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int num = random.Next(1, innum);
            int input = 0;
            int life = 5;

            Console.Write("Guess my number: ");

            while (num != input && life != 0)
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input < num)
                {
                    Console.WriteLine("The stored number is higher");
                    life--;
                    Console.WriteLine("You have " + life + " lives");
                }

                else if (input > num)
                {
                    Console.WriteLine("The stored number is lower");
                    life--;
                    Console.WriteLine("You have " + life + " lives");
                }
            }

            if (input == num)
            {
                Console.WriteLine("You found the number: " + num);
            }
            else
            {
                Console.WriteLine("Then number was: " + num);
            }
            Console.ReadLine();
        }

    }
}