using System.Collections.Generic;
using System.Linq;

namespace SWD_Decorator
{
    public class OffenciveEquipment : IEquipment, IAttack
    {
        public OffenciveEquipment()
        {
            
        }
        protected readonly List<IStat> stats=new List<IStat>();
        public void Attack(IAttackable target)
        {
            var attack = GetStat<AttackStat>();
            target.Attack(attack.StatValue);
        }

        public T GetStat<T>() where T : IStat
        {
            return stats.OfType<T>().FirstOrDefault();
        }       
    }
}