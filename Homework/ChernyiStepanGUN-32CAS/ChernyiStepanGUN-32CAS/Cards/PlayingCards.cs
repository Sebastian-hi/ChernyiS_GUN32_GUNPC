using System;
using System;

namespace ChernyiStepanGUN_32CAS.Cards
{
    //"Игральные карты и кости"

    public enum CardsSuit
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades
    }

    public enum CardsValue
    {
            Six = 6,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
    }

    public struct Card(CardsSuit cardsSuit, CardsValue cardsValue)
    {

            private readonly int _cardsSuit = (int)cardsSuit;
            private readonly int _cardsValue = (int)cardsValue;

            public readonly int CardsSuit
            {
                get { return _cardsSuit; }
            }

            public readonly int CardsValue
            {
                get { return _cardsValue; }
            }
    } 
}
