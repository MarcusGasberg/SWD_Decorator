namespace SWD_Decorator
{
    public class HealthStat : IStat 
    {
        public HealthStat(int healthBonus)
        {
            StatValue = healthBonus;
        }

        public int StatValue { get; }
    }
}