using System;
using System.Linq;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            // Try to solve this using ElementAt() first, and optionally anything else after.


            Console.WriteLine(Stringrev(reversed));
            Console.ReadLine();
        }
            static public string Stringrev(string input)
            {
                string rev = "";
                for (int i = input.Length -1; i >= 0; i--)
                {
                    rev += input[i];
                }
            return rev;
            }



           


        
    }
}
