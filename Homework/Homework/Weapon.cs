using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Weapon
    {
        public string Name { get; }
        private float minDamage;
        private float maxDamage;

        public Weapon(string name)
        {
            Name = name;
            SetDamageParams(1f, 10f); // Значения по умолчанию
        }

        public Weapon(string name, float minDamage, float maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        private void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage)
            {
                float temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;
                Console.WriteLine($"Некорректные входные данные для оружия {Name}: мин. урон > макс. урон");
            }

            if (minDamage < 1f)
            {
                this.minDamage = 1f;
                Console.WriteLine($"Форсированная установка минимального значения для оружия {Name}");
            }
            else
            {
                this.minDamage = minDamage;
            }

            if (maxDamage <= 1f)
            {
                this.maxDamage = 10f;
            }
            else
            {
                this.maxDamage = maxDamage;
            }
        }

        public float GetDamage()
        {
            return (minDamage + maxDamage) / 2;
        }
    }
}
