using System.Collections.Generic;
using System.Linq;
namespace SWD_Decorator
{
    public class PlayerEquipment
    {
        private readonly List<IEquipment> _playerEquipments = new List<IEquipment>();

        public void AddEquipment(IEquipment equipment)
        {
            _playerEquipments.Add(equipment);
        }

        public List<IAttack> GetWeapons()
        {
            return _playerEquipments.OfType<IAttack>().ToList();
        }

        public int CalculateTotalStatBonus<T>() where T : IStat
        {
            var bonus = 0;
            foreach (var playerEquipment in _playerEquipments)
            {
                bonus += playerEquipment.GetStat<T>()?.StatValue ?? 0;
            }
            return bonus;
        }
    }
}