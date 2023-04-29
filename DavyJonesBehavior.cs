using System;
using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class DavyJonesBehavior : IAttack, IDefend
    {
        public void Attack(){
            System.Console.WriteLine();
            System.Console.WriteLine("Davy Jones attacks! 'Cannon fire! BOOM!'");
        }
        public void Defend(){
            System.Console.WriteLine("Attack blocked!");
        }
    }
}