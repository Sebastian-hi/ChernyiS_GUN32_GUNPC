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
    private float minValue;
    private float maxValue;


    public Weapon(string name)
    {
        Name = name;
    }

    public Weapon(string name, float minValue, float maxValue) : this(name)
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public float GetInterval() 
    {
        Interval interval = new Interval(minValue, maxValue);

        float dmg = interval.Get(minValue, maxValue);
        return dmg;

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
                Console.WriteLine("Некорректные данные, минимальное значение не может быть больше максимального");
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
