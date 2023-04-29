using System;
using PA4_laineykersey.Interfaces;
namespace PA4_laineykersey
{
    public class DavyJones : Character
    {
        public DavyJones(){
            attackBehavior = new DavyJonesBehavior();
            defendBehavior = new DavyJonesBehavior();
        }
        
    }
}