namespace SWD_Decorator
{
    public class AttackStat : IStat
    {
        public AttackStat(int attackBonus)
        {
            StatValue = attackBonus;
        }
        public int StatValue { get; }
    }
}