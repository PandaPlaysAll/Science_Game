using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Item : GameObject
    {
       
        private ItemType _type;
        public Item (string name, string desc, ItemType itemType) : base(name, desc)
        {
          
            _type = itemType;
        }


        public ItemType Type
        {
            get { return _type; }
        }


        
    }
}
