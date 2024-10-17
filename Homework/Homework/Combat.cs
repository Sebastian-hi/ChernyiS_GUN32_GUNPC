using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Homework;

internal class Combat
{
    int Index = 0;

    int[] Rate = new int[1];


    public static void StartCombat(Unit unit, Unit unit1)
    {


        do
        {
            Random random = new Random();
            int x = random.Next(10);
            if (((x % 2) == 0))
            {
                unit.health -=unit1.Damage;
                Console.WriteLine($"{unit1.Name} неистово бьёт на {unit1.Damage} и у бойца {unit.Name} остаётся {unit.health} ");
            }
            else
            {
                unit1.health -=unit.Damage;
                Console.WriteLine($"{unit.Name} рассекает мечом на {unit.Damage} у бойца {unit1.Name} остаётся {unit1.health} ");
            }
        }

        while ((unit.health >= 0) && (unit1.health >= 0));

        Console.WriteLine($"{unit.Name}{unit.health} и {unit1.Name} {unit1.health}");
    }

    static void ShowResults(string[] args)
    {

    }
   
    
}