using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {

                foreach (int things in matrix)
                {
                    Console.WriteLine(things);
                }
            }
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            Console.ReadLine();
        }
    }
}