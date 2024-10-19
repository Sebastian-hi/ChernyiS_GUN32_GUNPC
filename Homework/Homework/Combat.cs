using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework;

internal class Combat
{ 
        static string[] RateArray = [];

        public static void StartCombat(Unit unit, Unit unit1)
        {



            do
            {

                Random random = new Random();
                int x = random.Next(10);
                if (((x % 2) == 0))
                {
                    unit.health -= unit1.Damage; // бьёт второй               

                    Rate unitPunch = new Rate();
                    unitPunch.Name = unit1.Name;
                    unitPunch.Damage = unit1.Damage;
                    unitPunch.Health = unit.health;

                    Array.Resize(ref RateArray, RateArray.Length + 1);
                    int index = RateArray.Length - 1;
                    RateArray[index] = unitPunch.Name + " нанёс " + unitPunch.Damage + " урона, у соперника осталось " + unitPunch.Health + " хп ";
                }

                else
                {
                    unit1.health -= unit.Damage; // бьёт первый

                    Rate unitPunch = new Rate();
                    unitPunch.Name = unit.Name;
                    unitPunch.Damage = unit.Damage;
                    unitPunch.Health = unit1.health;

                    Array.Resize(ref RateArray, RateArray.Length + 1);
                    int index = RateArray.Length - 1;
                    RateArray[index] = unitPunch.Name + " нанёс " + unitPunch.Damage + " урона, у соперника осталось " + unitPunch.Health + " хп ";
                }
            }
            while ((unit.health >= 0) && (unit1.health >= 0));

            Console.WriteLine($"{unit.Name}{unit.health} и {unit1.Name} {unit1.health}");



        }

        public struct Rate    //хранит информацию об одном кадре поединка между персонажами
        {
            public Rate(string name, int damage, float health)
            {
                Name = name;
                Damage = damage;
                Health = health;
            }

            public string Name;
            public float Damage;
            public float Health;
        }


        public static void ShowResults()
        {
            for (int i = 0; i < RateArray.Length; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, RateArray[i]);
                Console.WriteLine();
            }

        }


    }