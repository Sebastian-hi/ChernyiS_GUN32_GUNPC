using Homework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework;

public abstract class ArmorPiece
{
    public string Name { get; }
    private float armor;

    public ArmorPiece(string name, float armor)
    {
        Name = name;
        Armor = armor;
    }

    public float Armor
    {
        get => armor;
        set
        {
            if (value < 0f)
            {
                armor = 0f;
                Console.WriteLine($"Некорректно заданное свойство для {Name}: значение < 0");
            }
            else if (value > 1f)
            {
                armor = 1f;
                Console.WriteLine($"Некорректно заданное свойство для {Name}: значение > 1");
            }
            else
            {
                armor = value;
            }
        }
    }
}

public class Helm : ArmorPiece
{
    public Helm(float armor) : base("Helm", armor) { }
}

public class Shell : ArmorPiece
{
    public Shell(float armor) : base("Shell", armor) { }
}

public class Boots : ArmorPiece
{
    public Boots(float armor) : base("Boots", armor) { }
}