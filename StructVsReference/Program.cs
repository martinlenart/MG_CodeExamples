using System;

namespace StructVsReference
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

    public struct PlayingCardStruct
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;

        public string StringToPrint()
        {
            string sRet = $"Card is of color {Color} and value {Value}";
            return sRet;
        }
    }
    public class PlayingCardClass
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;

        public string StringToPrint()
        {
            string sRet = $"Card is of color {Color} and value {Value}";
            return sRet;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCardStruct sCard1;
            PlayingCardStruct sCard2 = new PlayingCardStruct { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Two };
            PlayingCardStruct sCard3 = new PlayingCardStruct { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Three };

            PlayingCardClass cCard1;
            PlayingCardClass cCard2 = new PlayingCardClass { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Two };
            PlayingCardClass cCard3 = new PlayingCardClass { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Three };

        }
    }
}
