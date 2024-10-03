using Homework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework;

 public class Helm
 {

    public string Name { get; }

    public float Armor { get; set; }

    public Helm(string name = "Helm")
    {
        Name = name;
    }

    public Helm(float armor, string name  = "Helm"): this(name)
    {
        Armor = armor;
       
    }

    //с этим типа закончил, так же с остальным

 }


public class Shell
    {


    }
    public class Boots
    {


    }


