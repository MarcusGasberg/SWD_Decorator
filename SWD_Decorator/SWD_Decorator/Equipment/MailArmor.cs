using System.Collections.Generic;

namespace SWD_Decorator
{
    public class MailArmor: DefensiveEquipment
    {
        public MailArmor()
        {
            Stats.Add(new HealthStat(20));
            Stats.Add(new ArmorStat(40));
        }
    }
}