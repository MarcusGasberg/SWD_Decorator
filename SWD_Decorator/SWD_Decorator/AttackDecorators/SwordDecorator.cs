using System;

namespace SWD_Decorator
{
    public class SwordDecorator : AttackDecorator
    {
        public override void Attack(IAttackable target)
        {
            base.Attack(target);
            Swing();
        }
        
        private void Swing()
        {
            Console.WriteLine("You swing your sword");
        }

        public SwordDecorator(IAttack toDecorate) : base(toDecorate)
        {
        }
    }
}