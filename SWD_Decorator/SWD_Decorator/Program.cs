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
            Player myPlayer = new Player("FrodoSwagginz");
            Player opponentPlayer = new Player("Gandank");
            myPlayer.Equipment.AddEquipment(new MailArmor());
            OffensiveEquipment sword = new Sword();
            sword = new SharpDecorator(sword);
            sword = new InflictsBleedDecorator(sword);
            myPlayer.Equipment.AddEquipment(sword);
            myPlayer.Attack(100);
            myPlayer.Heal(30);
            myPlayer.Attack(100);
            myPlayer.AttackTarget(opponentPlayer);

            Console.ReadLine();
        }
    }
}
