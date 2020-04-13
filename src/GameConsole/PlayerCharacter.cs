using System;

namespace GameConsole
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; } = -1; // Magic number
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue; // Magic number
    }
}