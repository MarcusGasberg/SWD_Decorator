using System.Collections.Generic;
using System.Linq;

namespace SWD_Decorator
{
    public class OffensiveEquipment : IEquipment, IAttack
    {
        public OffensiveEquipment()
        {
        }

        public List<IStat> Stats { get; protected set; }= new List<IStat>();
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