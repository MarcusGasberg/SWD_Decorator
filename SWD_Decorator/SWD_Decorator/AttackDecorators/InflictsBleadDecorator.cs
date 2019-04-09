using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace SWD_Decorator
{
    public class InflictsBleadDecorator : AttackDecorator
    {
        private int _bleedDamage;
        public int BleedDamageSpread { get; set; } = 5;
        public override void Attack(Attackable target)
        {
            base.Attack(target);
            _bleedDamage = (GetStat<AttackStat>().AttackBonus / 10);
            Bleed();
        }
        


        private void Bleed()
        {
            var BleedThreadRef = new ThreadStart(Bleeding);
            var BleedThread = new Thread(BleedThreadRef);
            BleedThread.Start();
        }

        private void Bleeding()
        {
            var Rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The target bleeds for "+ Rand.Next(_bleedDamage - BleedDamageSpread ,_bleedDamage + BleedDamageSpread) +" damage");
                Thread.Sleep(1000);
            }
        }
    }
}