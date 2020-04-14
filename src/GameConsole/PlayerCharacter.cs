using System;

namespace GameConsole
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; } // Shorthand syntax for Nullable<T> is int?
        public Nullable<DateTime> DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
    }
}