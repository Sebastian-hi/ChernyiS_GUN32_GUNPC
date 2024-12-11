using System;
using System.Threading.Channels;

namespace ChernyiStepanGUN_32CAS.Game
{
    public class Casino : IGame  //не реализуется интерфейс, тот что ниже(
    {
        public static void StartGame()
        {
            Console.WriteLine("\nНу что ж. Начнём!");
            int number;

            do
            {
                Console.WriteLine("Выберете \"1\" если хотите поиграть в BlackJack, либо \"2\" если хотите поиграть в кости.");
                int.TryParse(Console.ReadLine(), out number);
            }
            while (number !=1 && number!=2);

            if (number ==1)
            {
                BlackJack objJack = new(36);
                objJack.PlayGame();
            }

            else if (number ==2)
            {
                TheDiceGame objDiceGame = new(2, 1, 6);
                objDiceGame.PlayGame();
            }
        }



        //Механика казино
        //Реализация класса:

        //1. Загрузка и сохранение профиля игрока

        //2. Логика выбора игры из предложенных.
        //Экземпляры игр создаются в конструкторе.
        //Для выбора игры считывается ввод с консоли.
        //Пользователю Необходимо ввести 1 - для блэкджека и 2 - для игры в кости.
        //3. Логика начала игры и отображение результата.
        //Должна быть подписка на события CasinoGameBase.
        //Примечание: реализация класса - на усмотрение разработчика.
        //Главное - должен быть реализован правильный флоу (см.раздел Игровой флоу)



    }

    public interface IGame
    {
        public static void StartGame() {}
    }

}
