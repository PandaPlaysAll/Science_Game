using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public abstract class Character : GameObject
    {
        //fields
        private int _health;
        private int _damage;
        private bool _stunned;
        private Inventory _inventory;

        public Character (string name, string desc) : base (name, desc) 
        {
            _stunned = false;
            _inventory = new Inventory();
            Health = 100;


        }

        public virtual void Attack(Character p2) { }


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

        public bool Stunned
        {
            get { return _stunned; }
            set { _stunned = value; }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
         
        }


    }
}
