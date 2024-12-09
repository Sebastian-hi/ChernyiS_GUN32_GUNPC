using System;

namespace ChernyiStepanGUN_32CAS.Welcome
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Приветствуем в нашем казино. Начнём с выбора профиля игрока.");
            Console.WriteLine("Если профиль не был ранее создан - не проблема, сейчас создадим.");
            Casino.StarGame();

        }
    }
}