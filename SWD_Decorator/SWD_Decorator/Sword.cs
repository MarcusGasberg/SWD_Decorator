namespace SWD_Decorator
{
    public class Sword : OffenciveEquipment
    {
        public Sword()
        {
            stats.Add(new AttackStat(50));
        }
    }
}