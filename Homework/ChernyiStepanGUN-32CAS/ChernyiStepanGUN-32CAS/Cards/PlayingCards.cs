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

            public readonly CardsSuit CardsSuit = cardsSuit;
            public readonly CardsValue СardsValue = cardsValue;

           
            public readonly int FactCardsValue
            {
                get
                {
                    if ((int)СardsValue == 14)   
                        return 11;
                    
                    if ((int)СardsValue > 10)
                        return 10;

                    else return (int)СardsValue;
                }
            }
    } 
}