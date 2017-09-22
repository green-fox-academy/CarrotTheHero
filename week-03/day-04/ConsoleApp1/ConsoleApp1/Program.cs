using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TowersOfHanoi
    {
        public static void Main(String[] args)
        {
            char FirstRod = 'A';
            char ThirdRod = 'C';
            char SecondRod = 'B';
            int NumberOfDisks = 4;

            solveTowers(NumberOfDisks, FirstRod, ThirdRod, SecondRod);
            Console.ReadLine();
        }

        private static void solveTowers(int n, char FirstRod, char ThirdRod, char SecondRod)
        {
            if (n > 0)
            {
                solveTowers(n - 1, FirstRod, SecondRod, ThirdRod);
                Console.WriteLine("Move disk from " + FirstRod + ' ' + ThirdRod);
                solveTowers(n - 1, SecondRod, ThirdRod, FirstRod);

            }
        }

    }
}
