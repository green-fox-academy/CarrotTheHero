using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write in a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2* num; i++)
            {
                Console.WriteLine();

                if (i % 2 == 0)
                {
                    for (int j = 0; j < num; j++)
                        Console.Write("% ");  
                }
                else if (i % 2 != 0)
                {
                    for (int j = 0; j < num; j++)
                        Console.Write(" " + "%");
                }
            }
            Console.ReadLine();
        }
    }
}
                    