namespace SWD_Decorator
{
    public class HealthStat : IStat 
    {
        private readonly int _healthBonus;

        public HealthStat(int healthBonus)
        {
            StatValue = healthBonus;
        }

        public int StatValue { get; }
    }
}