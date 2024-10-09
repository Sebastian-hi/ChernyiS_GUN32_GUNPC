using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using Homework;

namespace Homework;

internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Подготовка к бою: ");                                    //#1
        Console.WriteLine("Введите имя бойца: ");                                   //#2
        string name = Console.ReadLine();
        float health;
        float helmArmor;
        float shellArmor;
        float bootsArmor;
        float minDamage;
        float maxDamage;

        do
        {
            Console.WriteLine("Введите начальное здоровье бойца(10 - 100): ");          //#3

            float.TryParse(Console.ReadLine(), out health);
        }

        while ( health < 10 || health > 100);


        do
        {
            Console.WriteLine("Введите значение брони шлема от 0 до 1:");              //#4

            float.TryParse(Console.ReadLine(), out helmArmor);
        }
        while (helmArmor < 0 || helmArmor > 1);


        do
        {
            Console.WriteLine("Введите значение брони кирасы от 0 до 1");              //#5

            float.TryParse(Console.ReadLine(), out shellArmor);

        }
        while (shellArmor < 0 || shellArmor > 1);


        do
        {
            Console.WriteLine("Введите значение брони сапог от 0 до 1:");              //#6

            float.TryParse(Console.ReadLine(), out bootsArmor);

        }
        while (bootsArmor < 0 || bootsArmor > 1);


        do
        {
            Console.WriteLine("Укажите минимальный урон оружия (0-20):");               //#7
            float.TryParse(Console.ReadLine(), out minDamage);
        }
        while (minDamage < 0 || minDamage > 20);


        do
        {
            Console.WriteLine("Укажите максимальный урон оружия (20-40):");             //#8
            float.TryParse(Console.ReadLine(), out maxDamage);
        }
        while (maxDamage < 20 || maxDamage > 40);


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