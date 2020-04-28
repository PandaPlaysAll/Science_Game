using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Character : GameObject
    {
        //fields
        private int _health;
        private int _damage;

        public Character (string name, string desc) : base (name, desc) 
        {



        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


    }
}
