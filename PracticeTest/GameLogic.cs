using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class GameLogic
    {

        //healthbar


        //let user choose player,


        //GUI / Consolebased
        //create players here?
        public void CreateGame(Character p)
        {
          
            

        }

        public void AttackSequence(Character p1, Character p2)
        {
            if (p1 is Scientist) //make it read the only for certain potions
            {
                p1.Stunned = true;
            }
        }
    }
}
