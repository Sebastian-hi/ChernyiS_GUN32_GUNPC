using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public class UnitFactoryDemo
    {
        public static Unit CreatePlayer(string name)
        {
            var player = new Player(name, 30, 30, 6);

            player.AddItemToInventory(new Weapon(15, 10, "Bow"));
            player.AddItemToInventory(new Weapon(10, 15, "Sword"));
 
            player.AddItemToInventory(new Armour(10, 15, "Chainmail"));
            player.AddItemToInventory(new Armour(20, 5, "Сuirass"));

            player.AddItemToInventory(new HealthPotion("HealthPotion"));
            player.AddItemToInventory(new Grindstone("ArmourPotion"));
            return player;
        }

        public static Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 18, 18, 2);
        //new Goblin(GameConstants.Goblin, 18, 18, 2);
    }
}
