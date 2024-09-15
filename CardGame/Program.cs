using System.Text;
using System.Threading.Tasks;
using static System.Console;
using GameLibrary.Shared;
using System;

namespace CardGame
{
    public class Program
    {
        static void Main()
        {
            PokerDeck pokerDeck = new PokerDeck();
            BlackjackDeck blackjackDeck = new BlackjackDeck();

            var pokerHand = pokerDeck.DealCards();
            
            foreach(var card in pokerHand)
            {
                WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }

            WriteLine(Environment.NewLine);

            var blackjackHand = blackjackDeck.DealCards();
        
            foreach (var card in blackjackHand)
            {
                WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }
            ReadLine();

        }
    }
}
