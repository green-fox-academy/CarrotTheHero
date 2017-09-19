using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            Console.WriteLine(Lines(path));
            Console.ReadLine();
        }

        private static int Lines(string path)
        {
            try
            {
                string[] content = File.ReadAllLines(path);
                return content.Length;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
