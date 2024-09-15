using System.Collections.Generic;
namespace GameLibrary.Shared
{
    public class PokerDeckModel : DeckModel
    {

        public PokerDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCard()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(RequestCard());
            }

            return output;
        }
    }
}
