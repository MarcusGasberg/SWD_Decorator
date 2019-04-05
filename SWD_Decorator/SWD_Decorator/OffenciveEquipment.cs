namespace SWD_Decorator
{
    public class OffenciveEquipment : IEquipment, IAttack
    {
        public void Attack(Attackable target)
        {
            throw new System.NotImplementedException();
        }

        public T GetStat<T>() where T : IStat
        {
            throw new System.NotImplementedException();
        }
    }
}