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
        public PlayingCardColor Color { get; init; }
        public PlayingCardValue Value { get; init; }

        public string StringToPrint()
        {
            string sRet = $"Card is of color {Color} and value {Value}";
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
        public PlayingCardColor Color { get; set; }
        public PlayingCardValue Value { get; set; }

        private bool _favoriteCard = false;
        public bool FavoriteCard 
        {   get { return _favoriteCard; }
            private set { _favoriteCard = value;} 
        }

        public string StringToPrint
        {
            get
            {
                string sRet = $"Card is of color {Color} and value {Value} and Favorite: {FavoriteCard}";
                return sRet;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCardStruct sCard1 = new PlayingCardStruct(true);
            PlayingCardStruct sCard2 = new PlayingCardStruct(false);

            PlayingCardStruct sCard3 = new PlayingCardStruct { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Four };

            Console.WriteLine(sCard1.StringToPrint());
            Console.WriteLine(sCard2.StringToPrint());
            Console.WriteLine(sCard3.StringToPrint());

            PlayingCardClass cCard1 = new PlayingCardClass { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Four };
            cCard1.FavoriteCard = true;
            Console.WriteLine(cCard1.FavoriteCard);
            Console.WriteLine(cCard1.StringToPrint);
        }
    }
}
