namespace SWD_Decorator
{
    public class AttackStat : IStat
    {
        public AttackStat(int attackBonus)
        {
            AttackBonus = attackBonus;
        }
        public int AttackBonus { get; set; }
    }
}