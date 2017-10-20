using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Card
    {
        Game myGame = new Game();

        public Suit SuitOfCard { get; set; }
        public Rank RankOfCard { get; set; }

        public Card(Suit suit, Rank rank)
        {
            SuitOfCard = suit;
            RankOfCard = rank;
        }
        public string GetCard()
        {
            return String.Format("{0} - {1}", SuitOfCard, RankOfCard);
        }

        public int GetCardTheTrueValue()
        {
            int myScore = 0;
            if ((int)RankOfCard < 11)
            {
                myScore += (int)RankOfCard;
            }
            else if ((int)RankOfCard > 10 && (int)RankOfCard < 14)
            {
                myScore += 10;
            }
            else if ((int)RankOfCard == 14 && myGame.playerHand < 11)
            {
                myScore += 11;
            }
            else
            {
                myScore += 1;
            }
            return myScore;
        }

    }
}

public enum Color
{
    Red,
    Black
}
public enum Suit
{
    Clubs,
    Diamonds,
    Hearths,
    Spades
}
public enum Rank
{
    Two = 2,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace,
}
