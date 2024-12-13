using ChernyiStepanGUN_32CAS.Cards;

namespace ChernyiStepanGUN_32CAS.Game
{
    public class TheDiceGame(int NumberOfDice, int MinValue, int MaxValue) : CasinoGameBase
    {
        private int _diceCount = NumberOfDice;
        private int _min = MinValue;
        private int _max = MaxValue;

        public bool Win = false;
        public bool Lose = false;
        public bool Draw = false;

        public override void PlayGame()
        {
            FactoryMethod();
        }
        
        private int RollDice(List<Dice> dice)
        {
            var total = 0;
            for (var i = 0; i < _diceCount; i++)
                total += dice[i].Number;

            return total;
        }

        private protected override void FactoryMethod()   //+ НУЖНО СДЕЛАТЬ СТАВКУ: см. "Игровой флоу"
        {

            List <Dice> _dice = new List<Dice>(_diceCount);
            for (int i = 0; i < _diceCount; i++)
            {
                _dice.Add(new Dice(_min, _max));
            }

            Console.WriteLine("\nПринято. Выбрана игра в кости.");
            Console.WriteLine("Цель этой игры набрать больше очков кидая 2 кости.");
            Console.WriteLine("И кстати, Вам повезло. Вы ходите первыми.");

            Joke();

            Console.WriteLine("Всё понятно, бросаем...\n");
            Console.WriteLine("____________________________________________\n");

            int valuePlayer = RollDice(_dice);
            Console.WriteLine("Вы уверенно бросаете! Выпало: {0}", valuePlayer);

            int valueMachine = RollDice(_dice);
            Console.WriteLine("Грозная машина бросает! Выпадает: {0}", valueMachine);

            if (valuePlayer > valueMachine)                                 //КАК БУДУТ ГОТОВЫ ИВЕНТЫ
            {
                Console.WriteLine("Поздравляем! Вы Победили.");
                Win = true;
                OnWinInvoke();
            }

            else if (valueMachine >  valuePlayer)
            {
                Console.WriteLine("Ну, что ж. Повезёт в другой раз. Написать о вреде азартных игр?");
                Lose = true;
                OnLooseInvoke();
            }   

            else if (valueMachine == valuePlayer)
            {
                Console.WriteLine("Вот это да! Ничья. Победила дружба.");
                OnDrawInvoke();
            }
        }
        private static void Joke()
        {
            int choise;
            Console.WriteLine("\nВыберете, как будете кидать кости:");
            Console.WriteLine("№1 - тихонечко бросать и приговаривать на удачу");
            Console.WriteLine("№2 - не подавая виду, что играете чуть ли не на последние деньги");
            Console.WriteLine("№3 - яростно бросать и потом ловить, чтобы не упали с стола\n");

            do
            {
                Console.WriteLine("Какая наша тактика? 1-3?");
                int.TryParse(Console.ReadLine(), out choise);
            }
            while (choise != 1 && choise != 2 && choise != 3);
        }
    }
}
