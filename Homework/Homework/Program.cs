using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using Homework;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Подготовка к бою: ");                                    //#1
            Console.WriteLine("Введите имя бойца: ");                                   //#2
            string name = Console.ReadLine();


            Console.WriteLine("Введите начальное здоровье бойца(10 - 100): ");          //#3

            obratno: float.TryParse(Console.ReadLine(), out float health);
                
             if (health<10 || health>100)
             {
                Console.WriteLine("Напишите именно число от 10 до 100:");
                goto obratno;
             }
             else { }


            Console.WriteLine("Введите значение брони шлема от 0 до 1:");              //#4

            obratno1:  float.TryParse(Console.ReadLine(), out float helmArmor);

            if (helmArmor < 0 || helmArmor > 1)
            {
                Console.WriteLine("Напишите именно число от 0 до 1: (например 0.5 может подойти..)");
                goto obratno1;
            }
            else { }


            Console.WriteLine("Введите значение брони кирасы от 0, до 1");              //#5

            obratno2: float.TryParse(Console.ReadLine(), out float shellArmor);
            if (shellArmor < 0 || shellArmor > 1)
            {
                Console.WriteLine("Напишите именно число от 0 до 1: (например 0.5 может  подойти..)");
                goto obratno2;
            }
            else { }

            Console.WriteLine("Введите значение брони сапог от 0, до 1:");              //#6

            obratno3: float.TryParse(Console.ReadLine(), out float bootsArmor);
            if (bootsArmor < 0 || bootsArmor > 1)
            {
                Console.WriteLine("Напишите именно число от 0 до 1: (например 0.5 может  подойти..)");
                goto obratno3;
            }
            else { }

            Console.WriteLine("Укажите минимальный урон оружия (0-20):");               //#7
            obratno4:  float.TryParse(Console.ReadLine(), out float minDamage);
            if (minDamage < 0 || minDamage > 20)
            {
                Console.WriteLine("Надо указать минимальное значение оружия именно в пределах от 0 до 20 включительно. Например 10...");
                goto obratno4;
            }

            Console.WriteLine("Укажите максимальный урон оружия (20-40):");             //#8
            obratno5: float.TryParse(Console.ReadLine(), out float maxDamage);
            if (maxDamage < 20 || maxDamage > 40)
            {
                Console.WriteLine("Надо указать максимальный урон оружия именно в пределах от 20 до 40. Например 30! Решайте..");
                goto obratno5;
            }


                                                                                        // Создание экземпляров брони
            Helm helm = new Helm(helmArmor);
            Shell shell = new Shell(shellArmor);
            Boots boots = new Boots(bootsArmor);

                                                                                        // Создание экземпляра оружия
            Weapon weapon = new Weapon("Sword", minDamage, maxDamage);

                                                                                        // Создание экземпляра юнита
            Unit unit = new Unit(name, health);
            unit.EquipHelm(helm);
            unit.EquipShell(shell);
            unit.EquipBoots(boots);
            unit.EquipWeapon(weapon);

            Console.WriteLine($"Общий показатель брони равен: {unit.Armor}");
            Console.WriteLine($"Фактическое значение здоровья равно: {unit.RealHealth}");
        }
    }   
}