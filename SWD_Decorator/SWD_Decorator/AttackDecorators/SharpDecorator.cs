using System;

namespace SWD_Decorator
{
    public class SharpDecorator : AttackDecorator
    {
        public SharpDecorator(IAttack toDecorate) : base(toDecorate)
        {
        }

        public int BonusDamage { get; set; } = 10;

        public override void Attack(IAttackable target)
        {
            base.Attack(target);
            target.Attack(BonusDamage);
            Console.WriteLine($"{BonusDamage} BONUSDAMAGE!");
        }
    }
}