using System.Collections.Generic;
using System.Linq;

namespace SWD_Decorator
{
    public class OffenciveEquipment : IEquipment, IAttack
    {
        public OffenciveEquipment()
        {
            Stats = new List<IStat>();
        }

        protected readonly List<IStat> Stats;
        public virtual void Attack(IAttackable target)
        {
            var attack = GetStat<AttackStat>();
            target.Attack(attack.StatValue);
        }

        public T GetStat<T>() where T : IStat
        {
            return Stats.OfType<T>().FirstOrDefault();
        }       
    }
}