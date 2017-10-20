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
            Random random = new Random();

            var myGame = new Game();
            var thisDeck = new Deck();
            var myCard = new Card((Suit)random.Next(0, 4), (Rank)random.Next(0, 13));

            foreach (var card in thisDeck.cardPack)
            {
                Console.WriteLine(card.GetCard());
            }
            Console.WriteLine();
            Console.WriteLine("A Random Card: " + thisDeck.PullRandom().GetCard());
            Console.WriteLine("The First Card: " + thisDeck.PullFirst().GetCard());
            Console.WriteLine("The Last Card: " + thisDeck.PullLast().GetCard());
            Console.WriteLine();
            Console.WriteLine("The opponents points are: " + myGame.GenerateOpponentsPoint());
            Console.WriteLine("Your hand after the first pull: " + myGame.PullTwoCards());
            while (myGame.playerHand < 22)
            {
                Console.WriteLine("Would you like to draw more card? Y/N: ");
                string key = Console.ReadKey().Key.ToString();
                if (key.ToUpper() == "Y")
                {
                    myGame.playerHand += thisDeck.PullRandom().GetCardTheTrueValue();
                    Console.WriteLine();
                    Console.WriteLine(myGame.playerHand);
                }
            }
            

            Console.ReadLine();
        }
    }
}
