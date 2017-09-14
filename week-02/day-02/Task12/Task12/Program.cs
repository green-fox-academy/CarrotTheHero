using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = new int[] { 4, 5, 6, 7 };

            foreach (int word in af)
            {
                Console.WriteLine(word);
            }
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`
            Console.ReadLine();
        }
    }
}