using ChernyiStepanGUN_32CAS.Player;
using ChernyiStepanGUN_32CAS.Service;
using System.Numerics;

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


            if (File.Exists($"D:\\Casino.txt"))
            {
                player.CasinoMoney = Convert.ToInt32(saveLoadService.LoadData<string>($"D:\\Casino.txt"));
            }
            else
            {
                saveLoadService.SaveData($"D:\\Casino.txt", 10000);
                player.CasinoMoney = 10000;
            }



            if (File.Exists($"D:\\{namePlayer}.txt"))
            {
                Console.WriteLine("Рады видеть Вас снова, {0}!", namePlayer);
                player.Name = namePlayer;
                player.PlayerMoney = Convert.ToInt32(saveLoadService.LoadData<string>($"D:\\{namePlayer}.txt"));
            }

            else
            {
                Console.WriteLine("Рады видеть нового игрока в нашем казино!");
                saveLoadService.SaveData<string>($"D:\\{namePlayer}.txt", namePlayer);
                saveLoadService.SaveData($"D:\\{namePlayer}.txt", 1000);
                player.PlayerMoney = 1000;
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

            if(player.PlayerMoney <= 0)
            {
                Console.WriteLine("“No money? Kicked");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Отлично! А теперь какая ставка?");
            Console.WriteLine("Ваш баланс: {0}$", player.PlayerMoney);

            int bet;

            do
            {
                int.TryParse(Console.ReadLine(), out bet);

                if (bet > player.PlayerMoney)
                {
                    Console.WriteLine("Увы, ставка больше вашего баланса.");
                }

                if(bet<10)
                {
                    Console.WriteLine("Ставка должна быть хотя бы больше 10$");
                }
            }
            while (bet !> player.PlayerMoney || bet !< 10);

            Console.WriteLine("Гуд. Ставка {0}$ принята.", bet);

            player.Bet = bet;

            if (number ==1)
            {
                BlackJack objJack = new(36);
                objJack.PlayGame();

                if (objJack.Win == true)
                {
                    player.PlayerMoney += player.Bet;
                    player.CasinoMoney -= player.Bet;

                    if (player.PlayerMoney > 4000)
                    {
                        player.PlayerMoney = player.PlayerMoney / 2;
                        Console.WriteLine("You wasted half of your bank money in casino’s bar");
                    }
                }
                else if (objJack.Lose == true)
                {
                    player.PlayerMoney -= player.Bet;
                    player.CasinoMoney += player.Bet;
                }
            }

            else if (number ==2)
            {
                TheDiceGame objDiceGame = new(2, 1, 6);
                objDiceGame.PlayGame();

                if (objDiceGame.Win == true)
                {
                    player.PlayerMoney += player.Bet;
                    player.CasinoMoney -= player.Bet;

                    if (player.PlayerMoney > 4000)
                    {
                        player.PlayerMoney = player.PlayerMoney / 2;
                        Console.WriteLine("You wasted half of your bank money in casino’s bar");
                    }
                }
                else if (objDiceGame.Lose == true)
                {
                    player.PlayerMoney -= player.Bet;
                    player.CasinoMoney += player.Bet;
                }
            }
            if (player.CasinoMoney <= 0)
            {
                Console.WriteLine($"{player.Name} Разорил казино, на его месте построят новое");
                player.CasinoMoney = 10000;
            }
            saveLoadService.SaveData($"D:\\{namePlayer}.txt", player.PlayerMoney);
            saveLoadService.SaveData($"D:\\Casino.txt", player.CasinoMoney);
            Console.WriteLine("\nБлагодарим за игру. Будем ждать Вас снова.");
        }
    }

    public interface IGame
    {
        public static void StartGame() {}
    }
}
