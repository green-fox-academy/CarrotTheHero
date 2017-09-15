using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write in a number: ");
            string input = Console.ReadLine();

            int howmany = input.ToString().Length;
            
            char[] onebyone = input.ToCharArray();

            for (int i = 0; i < onebyone.Length; i++)
            {
                Math.Pow(onebyone[], howmany);
            }

            Console.ReadLine();
        }
    }
    
}
