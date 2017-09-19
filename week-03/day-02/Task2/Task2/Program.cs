using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine(path);
            }
            catch
            {
                Console.WriteLine("Sorry can't read the file :(");
            }
            Console.ReadLine();
        }
    }
}
