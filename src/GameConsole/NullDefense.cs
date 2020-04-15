namespace GameConsole
{
    public class NullDefense : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 0; // "do nothing behavior"
        }
    }
}