using System;
using System.Runtime.InteropServices;

namespace SWD_Decorator
{
    public class Player : IAttackable
    {
        private int _baseHealth = 100;
        public PlayerEquipment Equipment { get; set; } = new PlayerEquipment();

        public Player()
        {
            Health = MaxHealth;
        }

        public int MaxHealth => _baseHealth + Equipment.CalculateTotalStatBonus<HealthStat>();
        public int Health { get; set; }

        public void Heal(int healthToRestore)
        {
            Health += healthToRestore;
            Health = Health <= MaxHealth ? Health : MaxHealth;
        }

        public void AttackTarget(Attackable target)
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
            Console.WriteLine(Health <= 0 ? $"Attackable took {damage} damage and is dead!" : $"Attackable took {damage} and its health is {Health}");
        }
    }
}