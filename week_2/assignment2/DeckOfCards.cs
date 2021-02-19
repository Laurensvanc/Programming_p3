using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class DeckOfCards
    {
        private List<PlayingCard> deck;

        public DeckOfCards()
        {
            deck = new List<PlayingCard>();

            for (int i = 0; i < 4; i++)
            {
                for (int f = 0; f < 13; f++)
                {
                    deck.Add(new PlayingCard());
                }
            }
        }

        private void InitCards()
        {

        }

        void Print()
        {

        }
    }
}
