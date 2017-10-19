using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        Deck myDeck = new Deck();

        public Game()
        {
            Console.WriteLine("The opponents points are: " + GenerateEnemyPoints());
            Console.WriteLine("");
            PullTwoCards();
        }

        public int PullTwoCards()
        {
            return 0;
        }

        public int GenerateEnemyPoints()
        {
            Random random = new Random();

            int result = random.Next(15, 22);
            return result;
        }
    }
}
