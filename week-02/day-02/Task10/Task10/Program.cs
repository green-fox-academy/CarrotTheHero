using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] s = new int[] { 1, 2, 3, 8, 5, 6 };

            s.SetValue(4, 3);
            Console.WriteLine(s[3]);
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            Console.ReadLine();
        }
    }
}