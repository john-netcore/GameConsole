namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public static SpecialDefence Null { get; } = new NullDefense();
        public abstract int CalculateDamageReduction(int totalDamage);

        private class NullDefense : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // "do nothing behavior"
            }
        }
    }
}