using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> cityQuery =
                    from city in cities
                    where city.StartsWith("A") && city.EndsWith("I")
                    select city;

            foreach (string city in cityQuery)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
