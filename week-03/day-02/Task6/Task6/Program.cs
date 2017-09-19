using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string path = "text.txt";
            string outtext = "texttwo.txt";

            Textcopy(path, outtext);
            Console.ReadLine();

        }

        private static void Textcopy(string path, string outtext)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string[] content = File.ReadAllLines(path);

                    using (StreamWriter writer = new StreamWriter(outtext))
                    {
                        for (int i = 0; i < content.Length; i++)
                        {
                            writer.WriteLine(content[i]);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Can't do it");
            }
        }
    }
}
