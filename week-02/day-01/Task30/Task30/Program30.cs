using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a number to build up the pyramid: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            if (sum % 2 == 0)
                ifEven(sum);
            else
                ifOdd(sum);

            Console.ReadLine();

        }

        public static void ifEven(int sum)
            {
                for (int i = 0; i < sum / 2; i++)
                {
                    for (int k = 1; k < sum - i + 1; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = sum / 2 - 1; i >= 0; i--)
                {
                    for (int k = sum - i + 1; k > 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
        }

        public static void ifOdd(int sum)
        {
                    for (int i = 0; i < sum / 2 + 1; i++)
                    {
                        for (int k = 1; k < sum - i + 1; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }
                    for (int i = sum / 2 - 1; i >= 0; i--)
                    {
                        for (int k = sum - i + 1; k > 1; k--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }
                    
        }
    }
}