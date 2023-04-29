using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class JackSparrowBehavior : IAttack, IDefend
    {
        public void Attack(){
            System.Console.WriteLine();
            System.Console.WriteLine("Jack Sparrow distracts! 'Haha! You looked over there, but I was over here!'");
        }
        public void Defend(){
            System.Console.WriteLine("Attack blocked!");
        }
    }
}