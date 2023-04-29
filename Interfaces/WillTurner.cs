using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class WillTurner : Character
    {
        public WillTurner(){
            attackBehavior = new WillTurnerBehavior();
            defendBehavior = new WillTurnerBehavior();
        }
    }
}