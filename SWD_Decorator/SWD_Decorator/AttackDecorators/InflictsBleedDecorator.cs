using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace SWD_Decorator
{
    public class InflictsBleedDecorator : AttackDecorator
    {
        private readonly int _bleedDamage;
        private readonly int _bleedSpread;
        private readonly object _bleedLock = new object();

        public InflictsBleedDecorator(OffensiveEquipment toDecorate) : base(toDecorate)
        {
            _bleedDamage = GetStat<AttackStat>().StatValue / 10;
            _bleedSpread = _bleedDamage / 2;
        }

        public override void Attack(IAttackable target)
        {
            base.Attack(target);
            Bleed(target);
        }
        


        private void Bleed(IAttackable target)
        {
            var bleedThreadRef = new ThreadStart(() => Bleeding(target));
            var bleedThread = new Thread(bleedThreadRef);
            bleedThread.Start();
        }

        private void Bleeding(IAttackable target)
        {
            var Rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                var bleedDamage = Rand.Next(_bleedDamage - _bleedSpread, _bleedDamage + _bleedSpread);
                lock (_bleedLock)
                {
                    target.Attack(bleedDamage);
                }
                Console.WriteLine("The target bleeds for "+ bleedDamage + " damage");
                Thread.Sleep(1000);
            }
        }

    }
}