using System.Collections.Generic;
using System.Linq;

namespace SWD_Decorator
{
    public class OffenciveEquipment : IEquipment, IAttack
    {
        protected readonly List<IStat> stats=new List<IStat>();
        public void Attack(IAttackable target)
        {
           // target.Attack();
        }

        public T GetStat<T>() where T : IStat
        {


            return stats.OfType<T>().FirstOrDefault();

        }

        public void Attack(Attackable target)
        {
            throw new System.NotImplementedException();
        }
    }
}