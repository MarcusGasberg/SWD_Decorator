namespace SWD_Decorator
{
    public abstract class AttackDecorator : IAttack
    {
        protected IAttack BaseAttack;

        public void AddNewAttackFunctionality(IAttack BaseAttack)
        {
            this.BaseAttack = BaseAttack;
        }
        
        public virtual void Attack(Attackable target)
        {
            BaseAttack.Attack(target);
        }
    }
}