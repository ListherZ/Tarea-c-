namespace DestructoresMagicos
{
    // Clases específicas de personajes
    public class Warrior : Character
    {
        public Warrior(string name, Armor armor, Weapon weapon)
            : base(name, 0, "Nada", 100, 1, armor, weapon)
        {
        }

        // mostrar detalles 
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Class: Warrior");
        }
    }
    public class Knight : Character
    {
        public Knight(string name, Armor armor, Weapon weapon)
            : base(name, 0, "Nada", 100, 1, armor, weapon)
        {
        }

        //  mostrar detalles
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Class: Knight");
        }
    }
    public class Assassin : Character
    {
        public Assassin(string name, Armor armor, Weapon weapon)
            : base(name, 0, "Nada", 100, 1, armor, weapon)
        {
        }

        // mostrar detalles 
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Class: Assassin");
        }
    }
    public class Mage : Character
    {
        public Mage(string name, Armor armor, Weapon weapon)
            : base(name, 0, "Nada", 100, 1, armor, weapon)
        {
        }

        // mostrar detalles 
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Class: Mage");
        }
    }
    public class Necromancer : Character
    {
        public Necromancer(string name, Armor armor, Weapon weapon)
            : base(name, 0, "Nada", 100, 1, armor, weapon)
        {
        }

        // mostrar detalles 
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Class: Necromancer");
        }
    }
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
}
