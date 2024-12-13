using ChernyiStepanGUN_32CAS.Game;

namespace ChernyiStepanGUN_32CAS.Welcome
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Приветствуем в нашем казино. Начнём с выбора профиля игрока.");
            Console.WriteLine("Если профиль не был ранее создан - не проблема, создадим.");
            Casino.StartGame();

        }
    }
}