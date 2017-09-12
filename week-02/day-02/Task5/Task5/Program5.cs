
using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            int num = 3;
            Console.WriteLine(Factorio(num));
            Console.ReadLine();
        }

        static public int Factorio(int input)
        {
            for (int i = input; i > 1; i--)
            {
                input *= (i - 1);
            }
            return input;
        }
    }
}