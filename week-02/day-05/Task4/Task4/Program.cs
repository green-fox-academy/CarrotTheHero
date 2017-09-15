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

            Console.Write("Guess my number: ");

            for (int i = 0; i < 5; i++)
            {



                while (num != input)
                {

                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < num)
                        Console.WriteLine("The stored number is higher");

                    else if (input > num)
                        Console.WriteLine("The stored number is lower");
                }
            }

            Console.WriteLine("You found the number: " + num);
            Console.ReadLine();
        }

    }
}