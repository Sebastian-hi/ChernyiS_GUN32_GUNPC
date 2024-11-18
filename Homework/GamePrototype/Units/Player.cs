using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Utils;
using System.Numerics;
using System.Text;

namespace GamePrototype.Units
{
    public sealed class Player : Unit
    {
        private readonly Dictionary<EquipSlot, EquipItem> _equipment = new() 
        {

        };
        

        public Player(string name, uint health, uint maxHealth, uint baseDamage) : base(name, health, maxHealth, baseDamage)
        {
            
        }
        public override void SwapWeapon()
        {
            foreach (var item in _equipment.ToList())
            {
                if (item.Value.Name == "Bow")
                {
                    _equipment.Remove(item.Key); //1 удаление текущего оружия
                    var Inventory_items = Inventory.Items; //проверка на существование нужного оружия в рюкзаке + 2 ремув из рюкзака на что менять
                    for (int i = 0; i < Inventory_items.Count; i++)
                    {
                        if (Inventory_items[i] is Weapon weapon)
                        {
                            Inventory.TryRemove(Inventory_items[i]);
                        }
                    }
                    AddItemToInventory(new Weapon(10, 15, "Sword")); //3
                    AddItemToInventory(new Weapon(15, 10, "Bow"));  //4
                }
                else if (item.Value.Name == "Sword")
                {
                    _equipment.Remove(item.Key); //1 удаление текущего оружия
                    var Inventory_items = Inventory.Items; //проверка на существование нужного оружия в рюкзаке + 2 ремув из рюкзака на что менять
                    for (int i = 0; i < Inventory_items.Count; i++)
                    {
                        if (Inventory_items[i] is Weapon weapon)
                        {
                            Inventory.TryRemove(Inventory_items[i]);
                        }
                    }
                    AddItemToInventory(new Weapon(15, 10, "Bow"));  //3
                    AddItemToInventory(new Weapon(10, 15, "Sword")); //4
                }
            }

        }
        public override void SwapArmour()
        {
            foreach (var item in _equipment.ToList())
            {
                if (item.Value.Name == "Chainmail")
                {
                    _equipment.Remove(item.Key); //1 удаление текущего Armour
                    var Inventory_items = Inventory.Items; //проверка на существование нужного Armour в рюкзаке + 2 ремув из рюкзака на что менять
                    for (int i = 0; i < Inventory_items.Count; i++)
                    {
                        if (Inventory_items[i] is Armour weapon)
                        {
                            Inventory.TryRemove(Inventory_items[i]);
                        }
                    }
                    AddItemToInventory(new Armour(20, 5, "Сuirass")); //3
                    AddItemToInventory(new Armour(10, 15, "Chainmail"));  //4
                }
                else if (item.Value.Name == "Сuirass")
                {
                    _equipment.Remove(item.Key); //1 удаление текущего Armour
                    var Inventory_items = Inventory.Items; //проверка на существование нужного Armour в рюкзаке + 2 ремув из рюкзака на что менять
                    for (int i = 0; i < Inventory_items.Count; i++)
                    {
                        if (Inventory_items[i] is Armour armour)
                        {
                            Inventory.TryRemove(Inventory_items[i]);
                        }
                    }
                    AddItemToInventory(new Armour(10, 15, "Chainmail")); //3
                    AddItemToInventory(new Armour(20, 5, "Сuirass"));    //4
                }
            }

        }
        public override uint GetUnitDamage()
        {
            if (_equipment.TryGetValue(EquipSlot.Weapon, out var item) && item is Weapon weapon)
            {
                weapon.ReduceDurability(1);
                Console.WriteLine("Прочность оружия: " + item.Durability);
                return BaseDamage + weapon.Damage;
            }

            return BaseDamage;
        }

        public override void HandleCombatComplete()
        {
            var items = Inventory.Items;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] is EconomicItem economicItem)
                {
                    UseEconomicItem(economicItem);
                    Inventory.TryRemove(items[i]);
                }
            }
        }

        public override void AddItemToInventory(Item item)
        {
            if (item is EquipItem equipItem && _equipment.TryAdd(equipItem.Slot, equipItem))
            {
                // Item was equipped
                return;
            }
            base.AddItemToInventory(item);
        }

        private void UseEconomicItem(EconomicItem economicItem)
        {
            if (economicItem is HealthPotion healthPotion)
            {
                Health += healthPotion.HealthRestore;
            }
            if (economicItem is Grindstone grindstone)
            {
                if (_equipment.TryGetValue(EquipSlot.Weapon, out var item) && item is Weapon weapon)
                {
                    weapon.Repair(grindstone.ArmourRestore);
                    Console.WriteLine("Использован камень, прочность оружия: " + weapon.Durability);
                }
            }
        }

        protected override uint CalculateAppliedDamage(uint damage)
        {
            if (_equipment.TryGetValue(EquipSlot.Armour, out var item) && item is Armour armour)
            {
                armour.ReduceDurability(1);
                Console.WriteLine("Прочность брони героя: " + item.Durability);
                damage -= (uint)(damage * (armour.Defence / 100f));
            }
            return damage;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Name);
            builder.AppendLine($"Health {Health}/{MaxHealth}");
            builder.AppendLine("Loot:");
            var items = Inventory.Items;
            for (int i = 0; i < items.Count; i++)
            {
                builder.AppendLine($"[{items[i].Name}] : {items[i].Amount}");
            }
            return builder.ToString();
        }
    }
}