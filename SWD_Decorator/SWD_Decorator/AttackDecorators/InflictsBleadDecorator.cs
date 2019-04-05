namespace SWD_Decorator
{
    public class InflictsBleadDecorator : AttackDecorator
    {
        public override void Attack(Attackable target)
        {
            base.Attack(target);
            Bleed();
        }

        private void Bleed()
        {
            throw new System.NotImplementedException();
        }
    }
}