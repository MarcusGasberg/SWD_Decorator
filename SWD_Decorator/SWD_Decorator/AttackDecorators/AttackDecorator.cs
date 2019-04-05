namespace SWD_Decorator
{
    public abstract class AttackDecorator : OffenciveEquipment
    {
        protected IAttack BaseAttack;

        public virtual void AddNewAttackFunctionality(IAttack BaseAttack)
        {
            this.BaseAttack = BaseAttack;
        }
        
        public virtual void Attack(Attackable target)
        {
            BaseAttack.Attack(target);
        }
    }
}