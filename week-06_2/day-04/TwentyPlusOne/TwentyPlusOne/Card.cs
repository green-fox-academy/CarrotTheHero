using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Card
    {
        public Suit SuitOfCard { get; set; }
        public Rank RankOfCard { get; set; }

        public Card(Suit suit, Rank rank)
        {
            SuitOfCard = suit;
            RankOfCard = rank;
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
    Two,
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
