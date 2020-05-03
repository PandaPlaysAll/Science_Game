using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class DemonAI : Character
    {
        public DemonAI(string name, string desc, int health = 50) :  base(name, desc)
        {
            Health = health;
        }
        public override void Attack(Character player) 
        {
            Random random = new Random();
            int dmg = random.Next(1, 30);
            //go through different items for different effects?
            player.Health -= dmg;
            Console.WriteLine("{0} attacked {1}, you have {2} left", Name, player.Name, player.Health);
        }
    }
}
