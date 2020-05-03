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
        private int _swordCount;
        private bool _stunned;
        private string _desc;
        private Inventory _inventory;

        public Character (string name, string desc) : base (name, desc) 
        {
            _swordCount = 0;
            Description = desc;
            _stunned = false;
            _inventory = new Inventory();
            Health = 100;
            Damage = 20;


        }

        public virtual void Attack(Character player) 
        {
            player.Health -= Damage;
            if (Inventory.HasItemType(ItemType.sword))
            {
                player.Health -= 20;
                Console.WriteLine("{0} attacked {1} with a sword!, {2} has {3} HP left", Name, player.Name, player.Name, player.Health);
            } else
            {
                Console.WriteLine("{0} attacked {1}, {2} has {3} HP left", Name, player.Name, player.Name, player.Health);
            }
            
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int SwordCount
        {
            get { return _swordCount; }
            set { _swordCount = value; }
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
        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }


    }
}
