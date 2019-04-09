namespace SWD_Decorator
{
    public class Sword : OffenciveEquipment
    {
        public Sword()
        {
            Stats.Add(new AttackStat(50));
        }
    }
}