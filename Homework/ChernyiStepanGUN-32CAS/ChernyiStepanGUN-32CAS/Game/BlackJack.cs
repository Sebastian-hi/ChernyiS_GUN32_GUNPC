using ChernyiStepanGUN_32CAS.Cards;

namespace ChernyiStepanGUN_32CAS.Game
{
    public class BlackJack(int cardsValue) : CasinoGameBase
    {
        private Queue<Card> _deck = new(cardsValue);

        private List<Card> _allCardList = new();

        public bool Win = false;
        public bool Lose = false;
        public bool Draw = false;

        public override void PlayGame()
        {
            FactoryMethod();
        }

        private protected override void FactoryMethod()
        {
            Console.WriteLine("\nОтлично. Выбран BlackJack.\n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 6; j < 15; j++)
                {
                    Card card = new((CardsSuit)i, (CardsValue)j);
                    _allCardList.Add(card);
                }
            }

            Console.WriteLine("Размешиваем карты....");
            Shuffle();
            Console.WriteLine("Раздаём карты..\n");

            Card _firstCardPlayer = _deck.Dequeue();
            Card _secondCardPlayer = _deck.Dequeue();
            Card _firstCardMachine = _deck.Dequeue();
            Card _secondCardMachine = _deck.Dequeue();

            Console.Write("Вам достались карты: ");
            ShowCard(_firstCardPlayer, _secondCardPlayer);

            Console.Write("\nА вашему противнику: ");
            ShowCard(_firstCardMachine, _secondCardMachine);

            Console.WriteLine("\n\nИ так. Итоги!\n");

            int valuePlayer = ShowScore(_firstCardPlayer, _secondCardPlayer);
            int valueMachine = ShowScore(_firstCardMachine, _secondCardMachine);

            Console.WriteLine("Сумма очков: {0}", valuePlayer);

            Console.WriteLine("А вашего противника: {0}", valueMachine);
            Console.WriteLine();


            Result(valuePlayer, valueMachine);


        }


        private void Result(int valuePlayer, int valueMachine)
        {
            if ((valuePlayer > valueMachine) || ((valuePlayer <= 21) && (valueMachine > 21 || valueMachine < valuePlayer)))
            {
                Console.WriteLine("Поздравляем! Победа!!");
                 Win = true;
                OnWinInvoke();
            }

            else if ((valuePlayer < valueMachine) || ((valueMachine <= 21) && (valuePlayer > 21 || valuePlayer < valueMachine)))
            {
                Console.WriteLine("Ну, что ж. Повезёт в другой раз. Написать о вреде азартных игр?");
                Lose = true;
                OnLooseInvoke();
            }

            else if ((valuePlayer >= 21) && (valueMachine >= 21))
            {
                Console.WriteLine("Вот это да! Ничья. Победила дружба.");
                OnDrawInvoke();
            }

            // НИЧЬЯ
            else if (valuePlayer == valueMachine)
            {
                ExtraRound(valuePlayer, valueMachine);
            }

            
            

            
        }

        private void ExtraRound(int valuePlayer, int valueMachine)
        {
            Console.WriteLine("Вот это да. У нас тут одинаковый счёт! Берём ещё по одной карте.\n");

            Console.Write("Вам досталась карта: ");
            Card _firstCardPlayer = _deck.Dequeue();
            ShowCard(_firstCardPlayer);

            Console.Write("А вашему противнику: ");
            Card _firstCardMachine = _deck.Dequeue();
            ShowCard(_firstCardMachine);

            valuePlayer += ShowScore(_firstCardPlayer);
            valueMachine += ShowScore(_firstCardMachine);

            int AllScore = valuePlayer + valueMachine;

            if ((valuePlayer == valueMachine) && (valuePlayer<21 && valueMachine<21))
            {
                Console.WriteLine("Ну вы ребята даёте..");
                Console.WriteLine("Ещё по одной карте. ");    // ЦИКЛ
                ExtraRound(valuePlayer, valueMachine);
            }

            Result(valuePlayer, valueMachine);
        }

        private void ShowCard(Card firstCard, Card secondCard)
        {
            Console.Write("{0} {1} ", firstCard.CardsSuit, firstCard.СardsValue);
            Console.Write("и {0} {1}.", secondCard.CardsSuit, secondCard.СardsValue);
        }

        private void ShowCard(Card onlyOneCard)
        {
            Console.WriteLine("{0} {1} ", onlyOneCard.CardsSuit, onlyOneCard.СardsValue);
        }


        private void Shuffle() 
        {
            Random random = new();

            for (int i = 0; i < 25; i++)
            {
                _allCardList.Reverse(random.Next(cardsValue / 2), random.Next(cardsValue / 4, cardsValue / 2));
            }

            foreach (Card card in _allCardList)
            {
                _deck.Enqueue(card);
            }
        }

        private int ShowScore(Card firstCard, Card secondCard)
        {
            int value = firstCard.FactCardsValue + secondCard.FactCardsValue;
            return value;
        }

        private int ShowScore(Card firstCard)
        {
            return firstCard.FactCardsValue;
        }

    }
}