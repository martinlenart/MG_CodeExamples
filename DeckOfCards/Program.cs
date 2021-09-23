using System;

namespace DeckOfCards
{
    public enum PlayingCardColor
    {
        Clubs, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
    }
    public enum PlayingCardValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Knight, Queen, King, Ace                // Poker Value order
    }

    public struct PlayingCard
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard[] deckOfCards = new PlayingCard[52];


            PlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Two };
            PlayingCard card2 = new PlayingCard { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Three };
            deckOfCards[0] = card1;
            deckOfCards[1] = card2;

            #region init a freash deck
            //You can loop in a for-loop using an enum.
            //Remember int is the underlying type of an enum
            int cardNr1 = 0;
            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
                {
                    //Alternative way as long as PlayingCard is a struct
                    deckOfCards[cardNr1].Color = color;
                    deckOfCards[cardNr1].Value = value;

                    //Alternative way working for PlayingCard being both class and struct
                    deckOfCards[cardNr1] = new PlayingCard { Color = color, Value = value };
                    
                    //Prepare to initialize next card
                    cardNr1++;
                }
            }

            //You can also use a foreach loop to initialize the deck of cards
            cardNr1 = 0;
            foreach (PlayingCardColor color in typeof(PlayingCardColor).GetEnumValues())
            {
                foreach (PlayingCardValue value in typeof(PlayingCardValue).GetEnumValues())
                {
                    //Alternative way as long as PlayingCard is a struct
                    deckOfCards[cardNr1].Color = color;
                    deckOfCards[cardNr1].Value = value;

                    //Alternative way working for PlayingCard being both class and struct
                    deckOfCards[cardNr1] = new PlayingCard { Color = color, Value = value };

                    //Prepare to initialize next card
                    cardNr1++;
                }
            }
            #endregion
        }
    }
}
//Exercise:
//1.        Create and initialize a fresh deck of cards use loops.
