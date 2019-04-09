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
            Player opponentPlayer = new Player();
            myPlayer.Equipment.AddEquipment(new MailArmor());
            var sword = new Sword();
            var sharpSword = new SharpDecorator(sword);
            myPlayer.Equipment.AddEquipment(sharpSword);
            myPlayer.Heal(30);
            myPlayer.Attack(100);
            myPlayer.Attack(100);
            myPlayer.AttackTarget(opponentPlayer);

            Console.ReadLine();
        }
    }
}
