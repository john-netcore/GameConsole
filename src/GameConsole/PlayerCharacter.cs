using System;

namespace GameConsole
{
    public class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; } // Shorthand syntax for Nullable<T> is int?
        public Nullable<DateTime> DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
        public int Health { get; set; } = 100;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public void Hit(int damage)
        {
            int damageReduction;

            damageReduction = _specialDefence.CalculateDamageReduction(damage);

            int totalDamageTaken = damage - damageReduction;

            Health = Health - totalDamageTaken;

            System.Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
    }
}