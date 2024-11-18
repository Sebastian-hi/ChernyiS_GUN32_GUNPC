using GamePrototype.Units;

namespace GamePrototype.Combat
{
    public sealed class CombatManager
    {
        private readonly Random _random = new();
        
        public Unit StartCombat(Unit player, Unit enemy) => PlayCombatRoutine(player, enemy);
        
        private Unit PlayCombatRoutine(Unit player, Unit enemy)
        {
            //player.SwapWeapon();
            //Console.WriteLine("Поменяли оружие");

            //player.SwapArmour();
            //Console.WriteLine("Поменяли броню");

            Console.WriteLine(GetCombatString());
            while (player.Health > 0 && enemy.Health > 0) 
            {
                if (Enum.TryParse<RockPaperScissors>(Console.ReadLine(), out var rockPaperScissors)) 
                {
                    HandleCombatInput(player, enemy, rockPaperScissors);
                }
                else
                {
                    Console.WriteLine(GetCombatString());
                }
            }
            if (player.Health > 0 && enemy.Health == 0) 
            {
                return player;
            }
            else if (player.Health == 0 && enemy.Health > 0) 
            {
                return enemy;
            }

            return null;
        }

        private string GetCombatString() => $"\nType {RockPaperScissors.Rock} = {(int)RockPaperScissors.Rock}"  +
            $"| {RockPaperScissors.Paper} = {(int)RockPaperScissors.Paper}" +
            $"| {RockPaperScissors.Scissors} = {(int)RockPaperScissors.Scissors}" + 
            $"| {RockPaperScissors.SwapWeapon} = {(int)RockPaperScissors.SwapWeapon}" +
            $"| {RockPaperScissors.SwapArmour} = {(int)RockPaperScissors.SwapArmour}";

        private void HandleCombatInput(Unit player, Unit enemy, RockPaperScissors rockPaperScissors)
        {
            
            var enemyInput = (RockPaperScissors) _random.Next(1, 3);
            Console.WriteLine($"\nResult player = {rockPaperScissors} | enemy = {enemyInput}");
            switch (rockPaperScissors) 
            {
                // player hit
                case RockPaperScissors.Rock when enemyInput == RockPaperScissors.Scissors:
                    ApplyDamage(player, enemy);
                    break;
                case RockPaperScissors.Scissors when enemyInput == RockPaperScissors.Paper:
                    ApplyDamage(player, enemy);
                    break;
                case RockPaperScissors.Paper when enemyInput == RockPaperScissors.Rock:
                    ApplyDamage(player, enemy);
                    break;
                // enemy hit
                case RockPaperScissors.Scissors when enemyInput == RockPaperScissors.Rock:
                    ApplyDamage(enemy, player);
                    break;

                case RockPaperScissors.Paper when enemyInput == RockPaperScissors.Scissors:
                    ApplyDamage(enemy, player);
                    break;

                case RockPaperScissors.Rock when enemyInput == RockPaperScissors.Paper:
                    ApplyDamage(enemy, player);
                    break;

                case RockPaperScissors.SwapWeapon:
                    player.SwapWeapon();
                    Console.WriteLine("Поменяли оружие");
                    Console.WriteLine("Пока выхватывали другое оружие, враг успел нанести урон");
                    ApplyDamage(enemy, player);
                    break;

                case RockPaperScissors.SwapArmour:
                    player.SwapArmour();
                    Console.WriteLine("Поменяли броню");
                    Console.WriteLine("Пока надевали новый комплект брони, враг успел нанести урон.");
                    ApplyDamage(enemy, player);
                    break;

                default:
                    Console.WriteLine("\nCombatants tried to hit, but missed :(");
                    break;
            }
        }

        private void ApplyDamage(Unit attacker, Unit defender)
        {
            defender.ApplyDamage(attacker.GetUnitDamage());
            Console.WriteLine($"{attacker.Name} hits {defender.Name}. {defender.Name} health {defender.Health}/{defender.MaxHealth}");
            if (defender.Health == 0) 
            {
                Console.WriteLine($"{defender.Name} is dead! \n");
                attacker.HandleCombatComplete();
            }
        }
    }
}