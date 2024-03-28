using System;

namespace DestructoresMagicos
{
  

  

    public class Character
    {
        public string Name { get; set; }
        public int AbilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public Armor BodyArmor { get; set; }
        public Weapon Weapon { get; set; }

        // Constructor
        public Character(string name, int abilityPoints, string faction, int healthPoints, int level, Armor armor, Weapon weapon)
        {
            Name = name;
            AbilityPoints = abilityPoints;
            Faction = faction;
            HealthPoints = healthPoints;
            Level = level;
            BodyArmor = armor;
            Weapon = weapon;
        }

        // Método para mostrar los detalles del personaje
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Ability Points: {AbilityPoints}");
            Console.WriteLine($"Faction: {Faction}");
            Console.WriteLine($"Health Points: {HealthPoints}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Armor: {BodyArmor.GetType().Name}");
            Console.WriteLine($"Weapon: {Weapon.GetType().Name}");
        }
    }

    // Clase base para armaduras
    public class Armor
    {
        public int ArmorPoints { get; set; }

        // Constructor
        public Armor(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }
    }

    // Clase base para armas
    public class Weapon
    {
        public int Damage { get; set; }

        // Constructor
        public Weapon(int damage)
        {
            Damage = damage;
        }
    }
}
