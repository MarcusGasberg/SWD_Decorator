namespace SWD_Decorator
{
    public class HealthStat : IStat 
    {
        public HealthStat(int healthBonus)
        {
            HealthBonus = healthBonus;
        }
        public int HealthBonus { get; set; }
    }
}