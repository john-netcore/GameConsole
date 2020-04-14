using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter { Name = string.Empty };
            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
