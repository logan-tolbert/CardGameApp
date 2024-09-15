using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Deck
    {
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        protected List<PlayingCard> drawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();

        public void CreateDeck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit });
                }
            }
        }

        public virtual void ShuffleDeck()
        {

        }

        public virtual PlayingCard RequestCard()
        {
            throw new NotImplementedException();
        }

        public abstract List<PlayingCard> DealCard();


    }

    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public int Value { get; set; }
    }


    public enum CardValue
    {
        Ace,
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
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}
