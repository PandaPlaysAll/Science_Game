using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class DemonAI : Character
    {
        //constructor
        public DemonAI(string name, string desc, int health = 50) :  base(name, desc)
        {
            Health = health;
        }

        //methods
        public override void Attack(Character player) 
        {
            Random random = new Random();
            int dmg = random.Next(1, 30); //randomize damage for the AI character || should extend to percentange basis
            player.Health -= dmg;
            Console.WriteLine("{0} attacked {1}, you have {2} left", Name, player.Name, player.Health);
        }
    }
}
