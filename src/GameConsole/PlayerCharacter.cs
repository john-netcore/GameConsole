using System;

namespace GameConsole
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; } = null; // Shorthand syntax for Nullable<T> is int?
        public Nullable<DateTime> DateOfBirth { get; set; } = null;
    }
}