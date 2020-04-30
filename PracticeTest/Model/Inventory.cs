using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    
    public class Inventory
    {
        private Dictionary<string, Item> _items; 

        public Inventory()
        {
            _items = new Dictionary<string, Item>();
        }

        public bool HasItem(string item)
        {
            if (_items.ContainsKey(item))
                return true;
            return false;
        }

        public bool HasItems(string[] items)
        {
            int count = 0;
            foreach (string item in items)
            {
                if (HasItem(item))
                    count++;
            }
            if (count == items.Length)
                return true;
            return false;
        }

        public bool HasAllItemTypes(ItemType[] types)
        {
            Dictionary<string, Item> temp = new Dictionary<string, Item>();
            int count = 0;
            foreach (ItemType type in types)
            {
                
             
                foreach (Item item in _items.Values)
                {
                    if (item.Type == type) 
                    { 
                        count++;
                        temp.Add(item.Name, item);
                        _items.Remove(item.Name);
                        break;
                    }
                }    
                

            }
            foreach (Item item in temp.Values)
            {
                _items.Add(item.Name, item);
            }
            if (count == types.Length)
                return true;
            return false;
        }
        //HasItemTypes?

        public void Take(string item)
        {
            if (HasItem(item))
                _items.Remove(item);
        }

        public void Put(Item item)
        {
            if (item is Item)
                _items.Add(item.Name, item);
            else
                Console.WriteLine("Invalid, not an item");

        }
    }
}
