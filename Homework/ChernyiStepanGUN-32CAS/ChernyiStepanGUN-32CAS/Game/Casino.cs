using ChernyiStepanGUN_32CAS.Player;
using ChernyiStepanGUN_32CAS.Service;

namespace ChernyiStepanGUN_32CAS.Game
{
    public class Casino : IGame
    {
        public static void StartGame()
        {
            Console.WriteLine("Введите ваше имя/псевдоним/кличку с детства..");
            string? namePlayer = Console.ReadLine();
            ISaveLoadService saveLoadService = new FileSystemSaveLoadService($"D:\\{namePlayer}.txt");
            Profile player = new();

            if(File.Exists($"D:\\{namePlayer}.txt"))
            {
                Console.WriteLine("Рады видеть Вас снова, {0}!", namePlayer);
                player.Name = namePlayer;
                player.Money = Convert.ToInt32(saveLoadService.LoadData<string>($"D:\\{namePlayer}.txt"));
            }

            else
            {
                Console.WriteLine("Рады видеть нового игрока в нашем казино!");
                saveLoadService.SaveData<string>($"D:\\{namePlayer}.txt", namePlayer);
                saveLoadService.SaveData($"D:\\{namePlayer}.txt", 1000);
                player.Money = 1000;
                player.Name = namePlayer;
            }


            Console.WriteLine("\nНу что ж. Начнём!");
            int number;
            do
            {
                Console.WriteLine("Выберете \"1\" если хотите поиграть в BlackJack, либо \"2\" если хотите поиграть в кости.");
                int.TryParse(Console.ReadLine(), out number);
            }
            while (number !=1 && number!=2);


            Console.WriteLine("Отлично! А теперь какая ставка?");
            Console.WriteLine("Ваш баланс: {0}$", player.Money);

            int bet;

            do
            {
                int.TryParse(Console.ReadLine(), out bet);

                if (bet > player.Money)
                {
                    Console.WriteLine("Увы, ставка больше вашего баланса.");
                }

                if(bet<10)
                {
                    Console.WriteLine("Ставка должна быть хотя бы больше 10$");
                }
            }
            while (bet !> player.Money || bet !< 10);

            Console.WriteLine("Гуд. Ставка {0}$ принята.", bet);

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

        /*
         
        Если игрок проиграл все деньги, то после выбора игры выводится сообщение о игра заканчивается с сообщением: 
        “No money? Kicked!”

        2. Если значение банка превышает максимально возможное значения, значение банка уменьшается в два раза. 
        При этом выводится сообщения “You wasted half of your bank money in casino’s bar

         
         */

        public void EndGame()
        {
            Console.WriteLine("No money? Kicked!");
        }

        public void OverMoneyGoToBar()
        {
            Console.WriteLine("You wasted half of your bank money in casino’s bar");
        }
    }

    public interface IGame
    {
        public static void StartGame() {}
    }


    
}
