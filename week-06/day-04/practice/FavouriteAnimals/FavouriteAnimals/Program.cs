using System.IO;
using System;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {           
            if (args.Length == 0)
            {
                Console.WriteLine("```C# FavouriteAnimals [animal] [animal]```");
            }
            else if (args.Length > 0)
            {
                string text = File.ReadAllText("favourites.txt");
                using (StreamWriter writer = File.AppendText("favourites.txt"))
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        if (!text.Contains(args[i]))
                        {
                            writer.WriteLine(args[i]);
                        }
                    }
                }
            }
        }
    }
}
