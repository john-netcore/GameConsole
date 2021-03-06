using System;

namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name)) //Returns also true if the string is empty.
            {
                System.Console.WriteLine("Player name is null or whitespace");
            }
            else
            {
                System.Console.WriteLine(player.Name);
            }

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

            if (player.IsNoob == null)
            {
                System.Console.WriteLine("Player newbie status is unknown");
            }
            else
            {
                System.Console.WriteLine(player.IsNoob);
            }
        }
    }
}