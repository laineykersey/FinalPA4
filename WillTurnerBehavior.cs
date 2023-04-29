using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class WillTurnerBehavior : IAttack, IDefend
    {
        public void Attack(){
            System.Console.WriteLine();
            System.Console.WriteLine("Will Turner attacks! 'Gotcha! You are no match for my sword!'");
        }
        public void Defend(){
            System.Console.WriteLine("Attack blocked!");
        }
    }
}