using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Unit
    {

        private float _health;
        private float _armor;
        
        private Helm _helm;

        public string Name { get; }

        public float Health => _health;

        public Unit() : this(name: "Unknown Unit", health: (10-100) ) { }  // БЛЯТЬ ЗДОРОВЬЕ?????


        public Unit(string name, float health)
        {
            Name = name;
            _health = health;
        }


        public float RealHealth()  //"пустые скобки тк не имеет аргументов"
        {
            return Health * (1 + Armor);
        }

        public float Armor
        {

            get { return (float)Math.Round(_armor, 2); }
            set
            {

                if (value >= 0 || value <= 1)
                {
                    _armor = value;
                }
                else
                {
                    Console.WriteLine("Введите плез числа от 0 до 1,00");
                }
            }
        }



        public void EquipHelm(Helm helm) {_helm = helm; }
        public float Damage { get; set;}

    }
}
