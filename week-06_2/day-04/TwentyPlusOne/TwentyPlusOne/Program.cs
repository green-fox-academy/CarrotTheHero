using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var thisDeck = new Deck(56); 

            foreach (var card in thisDeck.cardPack)
            {
                Console.WriteLine(card.GetCard());
            }
            Console.WriteLine();
            Console.WriteLine("A Random Card: " + thisDeck.PullRandom().GetCard());
            Console.WriteLine("The First Card: " + thisDeck.PullFirst().GetCard());
            Console.WriteLine("The Last Card: " + thisDeck.PullLast().GetCard());

            Console.ReadLine();
        }
    }
}
