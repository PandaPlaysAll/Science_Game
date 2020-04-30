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
        private Direction _direction;

        public Character (string name, string desc) : base (name, desc) 
        {
            _stunned = false;
            Health = 100;
            Direction = Direction.Right;


        }

        public virtual void Attack() { }


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

        public Direction Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }


    }
}
