using System;
using System.Runtime.InteropServices;

namespace SWD_Decorator
{
    public class Player : IAttackable
    {
        public string Name { get; }
        private readonly int _baseHealth = 100;
        public PlayerEquipment Equipment { get; set; } = new PlayerEquipment();

        public Player(string name)
        {
            Name = name;
            Health = MaxHealth;
        }

        public int MaxHealth => _baseHealth + Equipment.CalculateTotalStatBonus<HealthStat>();
        public int Health { get; set; }

        public void Heal(int healthToRestore)
        {
            Health += healthToRestore;
            Health = Health <= MaxHealth ? Health : MaxHealth;
            Console.WriteLine($"{Name} restored {healthToRestore} hp and now has {Health}");
        }

        public void AttackTarget(IAttackable target)
        {
            var weapons = Equipment.GetWeapons();
            foreach (var weapon in weapons)
            {
                weapon.Attack(target);
            }
        }

        public void Attack(int attack)
        {
            var damage = attack - Equipment.CalculateTotalStatBonus<ArmorStat>();
            damage = damage >= 0 ? damage : 0;
            Health -= damage;
            Console.WriteLine(Health <= 0 ? $"{Name} took {damage} damage and is dead!" : $"{Name} took {damage} and its health is {Health}");
        }
    }
}