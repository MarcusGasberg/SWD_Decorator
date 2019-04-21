namespace SWD_Decorator
{
    public abstract class AttackDecorator : OffensiveEquipment
    {
        private readonly OffensiveEquipment _toDecorate;

        protected AttackDecorator(OffensiveEquipment toDecorate)
        {
            _toDecorate = toDecorate;
            Stats = _toDecorate.Stats;
        }
        
        public override void Attack(IAttackable target)
        {
            _toDecorate.Attack(target);
        }
    }
}