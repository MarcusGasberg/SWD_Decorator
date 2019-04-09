namespace SWD_Decorator
{
    public abstract class AttackDecorator : OffenciveEquipment
    {
        protected readonly IAttack ToDecorate;

        public AttackDecorator(IAttack toDecorate)
        {
            ToDecorate = toDecorate;
        }
        
        public override void Attack(IAttackable target)
        {
            ToDecorate.Attack(target);
        }
    }
}