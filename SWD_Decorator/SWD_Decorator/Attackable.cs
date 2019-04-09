using System;

namespace SWD_Decorator
{
    public interface IAttackable
    {
        void Attack(int attack);
    }
    public class Attackable : IAttackable
    {
        
        private int _health = 100;
        public int Health
        {
            get => _health;
            set { _health = value; }
        }

        public void Attack(int attack)
        {
            Health -= attack;
            Console.WriteLine(Health <= 0 ? "Attackable is dead!" : $"Attackables health is {Health}");
        }
    }
}