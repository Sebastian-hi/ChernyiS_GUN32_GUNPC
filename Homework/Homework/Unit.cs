using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework;

public class Unit
{
    public string Name { get; }
    public float health;
    private Weapon weapon;
    private Helm helm;
    private Shell shell;
    private Boots boots;
    private const float baseDamage = 5f;

    public Unit(string name, float health)
    {
        Name = name;
        this.health = health;
    }

    public float Health => health;

    public float Damage
    {
        get
        {
            float weaponDamage = weapon?.GetDamage() ?? 0;
            return baseDamage + weaponDamage;
        }
    }

    public float Armor
    {
        get
        {
            float totalArmor = 0;
            if (helm != null) totalArmor += helm.Armor;
            if (shell != null) totalArmor += shell.Armor;
            if (boots != null) totalArmor += boots.Armor;
            return (float)Math.Round(totalArmor, 2);
        }
    }

    public float RealHealth => health * (1f + Armor);

    public bool SetDamage(float value)
    {
        health -= value * Armor;
        return health <= 0f;
    }

    public void EquipWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void EquipHelm(Helm helm)
    {
        this.helm = helm;
    }

    public void EquipShell(Shell shell)
    {
        this.shell = shell;
    }

    public void EquipBoots(Boots boots)
    {
        this.boots = boots;
    }
}