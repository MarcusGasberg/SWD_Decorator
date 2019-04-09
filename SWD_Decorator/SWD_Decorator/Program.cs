using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            myPlayer.Equipment.AddEquipment(new MailArmor());
            Console.WriteLine(myPlayer.Equipment.CalculateTotalStatBonus<HealthStat>());

            Console.ReadLine();
        }
    }
}
