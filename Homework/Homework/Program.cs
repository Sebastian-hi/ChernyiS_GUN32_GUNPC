using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using Homework;
using System.Runtime.InteropServices;

namespace Homework;

internal class Program
{
     static void Main(string[] args)
    {
        float health;
        float helmArmor;
        float shellArmor;
        float bootsArmor;
        float minDamage;
        float maxDamage;


        Console.WriteLine("Подготовка к бою: ");
        Console.WriteLine("Введите имя первого бойца: ");
        string name = Console.ReadLine();


        do                                                                                          // первый боец
        {
            Console.WriteLine($"Введите начальное здоровье бойца {name} (10 - 100): ");

            float.TryParse(Console.ReadLine(), out health);
        }

        while (health < 10 || health > 100);


        do
        {
            Console.WriteLine($"Введите значение брони шлема бойца {name} от 0 до 1:");

            float.TryParse(Console.ReadLine(), out helmArmor);
        }
        while (helmArmor < 0 || helmArmor > 1);


        do
        {
            Console.WriteLine($"Введите значение брони кирасы бойца {name} от 0 до 1");

            float.TryParse(Console.ReadLine(), out shellArmor);

        }
        while (shellArmor < 0 || shellArmor > 1);


        do
        {
            Console.WriteLine($"Введите значение брони сапог бойца {name} от 0 до 1:");

            float.TryParse(Console.ReadLine(), out bootsArmor);

        }
        while (bootsArmor < 0 || bootsArmor > 1);


        do
        {
            Console.WriteLine($"Укажите минимальный урон оружия бойца {name} (0-20):");
            float.TryParse(Console.ReadLine(), out minDamage);
        }
        while (minDamage < 0 || minDamage > 20);


        do
        {
            Console.WriteLine($"Укажите максимальный урон оружия бойца {name} (20-40):");
            float.TryParse(Console.ReadLine(), out maxDamage);
        }
        while (maxDamage < 20 || maxDamage > 40);


        // Создание экземпляров брони для первого бойца
        Helm helm = new Helm(helmArmor);
        Shell shell = new Shell(shellArmor);
        Boots boots = new Boots(bootsArmor);

        // Создание экземпляра оружия первого бойца
        Weapon weapon = new Weapon("Sword", minDamage, maxDamage);

        // Создание экземпляра первого бойца
        Unit unit = new Unit(name, health);
        unit.EquipHelm(helm);
        unit.EquipShell(shell);
        unit.EquipBoots(boots);
        unit.EquipWeapon(weapon);


        // второй боец


        float health1;
        float helmArmor1;
        float shellArmor1;
        float bootsArmor1;
        float minDamage1;
        float maxDamage1;

        Console.WriteLine("Введите имя второго бойца: ");
        string name1 = Console.ReadLine();


        do
        {
            Console.WriteLine($"Введите начальное здоровье бойца {name1} (10 - 100): ");

            float.TryParse(Console.ReadLine(), out health1);
        }

        while (health1 < 10 || health1 > 100);


        do
        {
            Console.WriteLine($"Введите значение брони шлема бойца {name1} от 0 до 1:");

            float.TryParse(Console.ReadLine(), out helmArmor1);
        }
        while (helmArmor1 < 0 || helmArmor1 > 1);


        do
        {
            Console.WriteLine($"Введите значение брони кирасы бойца {name1} от 0 до 1");

            float.TryParse(Console.ReadLine(), out shellArmor1);

        }
        while (shellArmor1 < 0 || shellArmor1 > 1);


        do
        {
            Console.WriteLine($"Введите значение брони сапог бойца {name1} от 0 до 1:");

            float.TryParse(Console.ReadLine(), out bootsArmor1);

        }
        while (bootsArmor1 < 0 || bootsArmor1 > 1);


        do
        {
            Console.WriteLine($"Укажите минимальный урон оружия бойца {name1} (0-20):");
            float.TryParse(Console.ReadLine(), out minDamage1);
        }
        while (minDamage1 < 0 || minDamage1 > 20);


        do
        {
            Console.WriteLine($"Укажите максимальный урон оружия бойца {name1} (20-40):");
            float.TryParse(Console.ReadLine(), out maxDamage1);
        }
        while (maxDamage1 < 20 || maxDamage1 > 40);


        // Создание экземпляров брони для второго бойца
        Helm helm1 = new Helm(helmArmor1);
        Shell shell1 = new Shell(shellArmor1);
        Boots boots1 = new Boots(bootsArmor1);

        // Создание экземпляра оружия для второго
        Weapon weapon1 = new Weapon("Sword", minDamage1, maxDamage1);

        // Создание экземпляра юнита для второго
        Unit unit1 = new Unit(name1, health1);
        unit1.EquipHelm(helm1);
        unit1.EquipShell(shell1);
        unit1.EquipBoots(boots1);
        unit1.EquipWeapon(weapon1);



        Console.WriteLine();
        Console.WriteLine("Отлично. Теперь посмотрим на них: ");
        Console.WriteLine();

                                                                            // Выводятся данные бойцов
        Console.WriteLine($"И так! Первый боец у нас {name}");
        Console.WriteLine($"Общий показатель брони  равен: {unit.Armor}");
        Console.WriteLine($"Фактическое значение здоровья равно: {unit.RealHealth}");
        Console.WriteLine($"Минимальный урон {minDamage}");
        Console.WriteLine($"Максимальный урон {maxDamage}");


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Второй боец у нас {name1}");
        Console.WriteLine($"Общий показатель брони  равен: {unit1.Armor}");
        Console.WriteLine($"Фактическое значение здоровья равно: {unit1.RealHealth}");
        Console.WriteLine($"Минимальный урон {minDamage1}");
        Console.WriteLine($"Максимальный урон {maxDamage1}");


        Combat combat = new Combat();

        Console.WriteLine();
        Console.WriteLine("Начало битвы! ");
        Combat.StartCombat(unit, unit1);
        Console.WriteLine();
        Console.WriteLine("Бой завершился! ");
        Combat.ShowResults();
    

     }
       
}   