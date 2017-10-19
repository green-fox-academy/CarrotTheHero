using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Deck
    {
        public List<Card> cardPack = new List<Card>();

        public Deck(int numberOfCards)
        {

            for (int i = 0; i < typeof(Suit).GetEnumNames().Count(); i++)
            {
                for (int j = 0; j < typeof(Rank).GetEnumNames().Count(); j++)
                {
                    cardPack.Add(new Card((Suit)i,(Rank)j));
                }
            }

            //SuffleDeck();
            //PullFirst();
            //PullLast();
            //PullRandom();
        }

        //private void PullRandom()
        //{
        //    throw new NotImplementedException();
        //}

        //private void PullLast()
        //{
        //    throw new NotImplementedException();
        //}

        //private void PullFirst()
        //{
        //    throw new NotImplementedException();
        //}

        //private void SuffleDeck()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
