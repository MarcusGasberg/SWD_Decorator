using System;

namespace SWD_Decorator
{
    public class SwordDecorator : AttackDecorator
    {
        public override void Attack(Attackable target)
        {
            base.Attack(target);
            Swing();
        }
        
        private void Swing()
        {
            Console.WriteLine("You swing your sword");
        }
    }
}