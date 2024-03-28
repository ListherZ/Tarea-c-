﻿using DestructoresMagicos;

public class Druid : Character
{
    public Druid(string name, Armor armor, Weapon weapon)
        : base(name, 0, "Nada", 100, 1, armor, weapon)
    {
    }

    // mostrar detalles 
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Class: Druid");
    }
}