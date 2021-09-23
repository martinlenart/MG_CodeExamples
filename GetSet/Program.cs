using System;

namespace GetSet
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
        public PlayingCardColor Color { get; }
        public PlayingCardValue Value { get; }

        public string StringToPrint()
        {
            string sRet = $"Card is of color {Color} and value {Value}";
            Color = PlayingCardColor.Clubs;
            return sRet;
        }
        public PlayingCardStruct(bool myFavoriteOrWorst)
        {
            if (myFavoriteOrWorst)
            {
                Color = PlayingCardColor.Hearts;
                Value = PlayingCardValue.Queen;
            }
            else
            {
                Color = PlayingCardColor.Clubs;
                Value = PlayingCardValue.Two;
            }
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
            Console.WriteLine("Hello World!");
        }
    }
}
