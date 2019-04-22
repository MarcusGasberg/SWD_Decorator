namespace SWD_Decorator
{
    public class Sword : OffensiveEquipment
    {
        public Sword()
        {
            Stats.Add(new AttackStat(50));
        }
    }
}