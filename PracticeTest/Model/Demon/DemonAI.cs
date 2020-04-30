using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class DemonAI : Character
    {
        public DemonAI(string name, string desc) : base(name, desc)
        {
            Health = 150;
        }
        public void Attack(Character player)
        {
            Random random = new Random();
            int dmg = random.Next(1, 30);
            player.Health -= dmg;
        }
    }
}
