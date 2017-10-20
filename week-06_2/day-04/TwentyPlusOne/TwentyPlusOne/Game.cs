using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        public static Random random = new Random();

        Deck myDeck = new Deck();
        Card myCard = new Card((Suit)random.Next(0,4),(Rank)random.Next(0,13));
        public int playerHand = 0;

        public Game()
        {
        }

        public int PullTwoCards()
        {
            int thefirsttwopulls = 0;
            thefirsttwopulls = myDeck.PullRandom().GetCardTheTrueValue();
            thefirsttwopulls += myDeck.PullRandom().GetCardTheTrueValue();
            playerHand += thefirsttwopulls;
            return playerHand;
        }

        public int GenerateOpponentsPoint()
        {
            Random random = new Random();

            int result = random.Next(15, 22);
            return result;
        }
    }
}
