using System;

namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            System.Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin == null)
            {
                System.Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                System.Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == null)
            {
                System.Console.WriteLine("No date of birth specified");
            }
            else
            {
                System.Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}