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
                    cardPack.Add(new Card((Suit)i, (Rank)j));
                }
            }

            ShuffleDeck();
            PullFirst();
            PullLast();
            PullRandom();
        }

        public Card PullRandom()
        {
            Random random = new Random();

            int indexToRemove = random.Next(0, cardPack.Count - 1);
            var cardDrawn = cardPack[indexToRemove];
            cardPack.RemoveAt(indexToRemove);
            return cardDrawn;
        }

        public Card PullLast()
        {
            var cardDrawn = cardPack[cardPack.Count - 1];
            cardPack.RemoveAt(cardPack.Count - 1);
            return cardDrawn;
        }

        public Card PullFirst()
        {
            var cardDrawn = cardPack[0];
            cardPack.RemoveAt(0);
            return cardDrawn;
        }

        public void ShuffleDeck()
        {
            List<int> deckOfShuffledCards = new List<int>();
            List<Card> shuffledDeck = new List<Card>();
            Random random = new Random();
            for (int i = 0; i < cardPack.Count; i++)
            {
                int indexOfCard = random.Next(0, cardPack.Count);
                while (deckOfShuffledCards.Contains(indexOfCard))
                {
                    indexOfCard = random.Next(0, cardPack.Count);
                }
                deckOfShuffledCards.Add(indexOfCard);
            }
            foreach (int index in deckOfShuffledCards)
            {
                shuffledDeck.Add(cardPack[index]);
            }
            for (int i = 0; i < cardPack.Count; i++)
            {
                cardPack[i] = shuffledDeck[i];
            }
            foreach (var card in cardPack)
            {
                Console.WriteLine(card.SuitOfCard + " - " + card.RankOfCard);
            }
        }
    }
}
