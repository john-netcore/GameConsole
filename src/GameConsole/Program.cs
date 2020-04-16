using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new PlayerCharacter(new DiamondSkinDefence()) { Name = "John" };
            var krolicka = new PlayerCharacter(new IronBonesDefence()) { Name = "Krolicka" };
            var gosia = new PlayerCharacter(SpecialDefence.Null) { Name = "Gosia" };

            john.Hit(10);
            krolicka.Hit(10);
            gosia.Hit(10);

            System.Console.WriteLine();
            PlayerDisplayer.Write(john);
            PlayerDisplayer.Write(krolicka);
            PlayerDisplayer.Write(gosia);
            Console.ReadLine();
        }
    }
}
