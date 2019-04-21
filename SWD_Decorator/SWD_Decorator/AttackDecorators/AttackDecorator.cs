using System.Linq;

namespace SWD_Decorator
{
    public abstract class AttackDecorator : OffensiveEquipment
    {
        private readonly OffensiveEquipment _toDecorate;

        protected AttackDecorator(OffensiveEquipment toDecorate)
        {
            _toDecorate = toDecorate;
        }
        
        public override void Attack(IAttackable target)
        {
            _toDecorate.Attack(target);
        }

        public override T GetStat<T>()
        {
            return _toDecorate.GetStat<T>();
        }
    }
}