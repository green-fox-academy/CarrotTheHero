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
                Console.WriteLine(card.SuitOfCard + " - " + card.RankOfCard);
            }
            Console.WriteLine();
            Console.WriteLine(thisDeck.PullRandom());
            Console.WriteLine(thisDeck.PullFirst());
            Console.WriteLine(thisDeck.PullLast());
            Console.ReadLine();
        }
    }
}
