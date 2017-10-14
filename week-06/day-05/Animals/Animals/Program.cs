using System;
using System.IO;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("```C# FavouriteAnimals [animal] [animal]```");
            }
            else
            {
                string text = File.ReadAllText("favourite.txt");
                using (StreamWriter writer = File.AppendText("favourite.txt"))
                {
                    foreach (var animal in args)
                    {
                        if (!text.Contains(animal))
                        {
                            writer.WriteLine(animal);
                        }
                        
                    }
                    
                }
            }
        }
    }
}
