namespace SWD_Decorator
{
    public class ArmorStat : IStat
    {
        public ArmorStat(int armorBonus)
        {
            StatValue = armorBonus;
        }

        public int StatValue { get; }
    }
}