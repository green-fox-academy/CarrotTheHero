using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFarm();
            Console.WriteLine();
        }

        static void CreateFarm()
        {
            Animal horse = new Animal();
            Animal duck = new Animal();
            Animal pig = new Animal();
        }
    }
}
