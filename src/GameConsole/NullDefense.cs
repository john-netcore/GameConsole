namespace GameConsole
{
    public class NullDefense : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0; // "do nothing behavior"
        }
    }
}