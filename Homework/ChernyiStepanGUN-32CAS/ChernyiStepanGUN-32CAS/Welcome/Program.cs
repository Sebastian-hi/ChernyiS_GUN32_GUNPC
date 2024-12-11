using ChernyiStepanGUN_32CAS.Game;
using System;

namespace ChernyiStepanGUN_32CAS.Welcome
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Приветствуем в нашем казино. Начнём с выбора профиля игрока.");
            Console.WriteLine("Если профиль не был ранее создан - не проблема, создадим.");
            Console.WriteLine("Введите ваше имя/псевдоним/кличку с детства..");
            string? text = Console.ReadLine();
            Console.WriteLine("\n_______________________________\nОчень приятно, {0}!", text);;
            Casino.StartGame();

        }
    }
}