using System.Collections.Generic;
using System.Linq;

namespace SWD_Decorator
{
    public class DefensiveEquipment : IEquipment
    {
        protected readonly List<IStat> Stats = new List<IStat>();

        public DefensiveEquipment()
        {
        }
        public void AddStat(IStat stat)
        {
            Stats.Add(stat);
        }

        public T GetStat<T>() where T : IStat
        {
            return Stats.OfType<T>().FirstOrDefault();
        }
    }
}