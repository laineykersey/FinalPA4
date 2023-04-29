using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class JackSparrow : Character
    {
            public JackSparrow(){
                attackBehavior = new JackSparrowBehavior();
                defendBehavior = new JackSparrowBehavior();
            }
        
    }
}