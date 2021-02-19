using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        PlayingCard()
        {
            Random rng = new Random();

            this.rank = 
        }

        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}
