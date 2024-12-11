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

            private readonly CardsSuit _cardsSuit = cardsSuit;
            private readonly CardsValue _cardsValue = cardsValue;

            public readonly CardsSuit CardsSuit
            {
                get { return  _cardsSuit; }
            }

            public readonly CardsValue CardsValue
            {
                get { return _cardsValue; }
            }
    } 
}
