namespace SWD_Decorator
{
    public class OffenciveEquipment : IEquipment, IAttack
    {
        public void Attack(Attackable target)
        {
            throw new System.NotImplementedException();
        }
    }
}