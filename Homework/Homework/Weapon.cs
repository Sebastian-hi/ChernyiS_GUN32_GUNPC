using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework;

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
            Console.WriteLine($"Некорректные данные для оружия {Name}: мин. урон > макс. урон");
        }

        if (minDamage < 1f)
        {
            this.minDamage = 1f;
            Console.WriteLine($"Установка минимального значения для оружия {Name}");
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

    public struct Interval
    {

        private float minValue;
        private float maxValue;

        public Interval(int minValue, int maxValue)
            : this ((float) minValue, (float) maxValue) {}

        public Interval(float minValue, float maxValue)
        {
            
            if (minValue > maxValue)
            {
                Console.WriteLine("Некорректные входные данные. minValue больше maxValue");
                this.minValue = maxValue;
                this.maxValue = minValue;
            }
            else
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
            }
        }

        public float Get(float minValue, float maxValue)                                                               //свойства
        {
            Random random = new Random();

            float between = random.Next((int)minValue, (int)maxValue);
            return between;
        }
        
        public float Min(float minValue, float maxValue)
        {
            return minValue;
        }

        public float Max(float minValue, float maxValue)
        {
            return maxValue;
        }

        public float Average(float minValue, float maxValue)
        {
            float average = (minValue + maxValue) / 2;
            return average;
        }


    }
}
