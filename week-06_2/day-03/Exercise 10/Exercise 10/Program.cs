using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxList = new List<Fox>();
            var fox1 = new Fox("bob", "oracle", "white");
            var fox2 = new Fox("george", "pallida", "green");
            var fox3 = new Fox("carl", "pallida", "yellow");
            var fox4 = new Fox("homer", "alpaga", "green");
            var fox5 = new Fox("hugh", "alpaga", "black");
            foxList.Add(fox1);
            foxList.Add(fox2);
            foxList.Add(fox3);
            foxList.Add(fox4);
            foxList.Add(fox5);

            FindTheGreenFox(foxList);
            Console.ReadLine();
        }

        private static void FindTheGreenFox(List<Fox> foxList)
        {
            var listOfFoxesQuery = from fox in foxList
                                   where fox.Color == "green"
                                   select fox;
            foreach (var fox in foxList)
            {
                Console.WriteLine(fox);
            }
        }
    }
}
