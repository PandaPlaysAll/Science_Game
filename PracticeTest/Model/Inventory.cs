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

        public int Count
        {
            get { return _items.Count; }
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



        public void RemoveItemType(ItemType type)
        {
            //only take first
            bool condition = false;
            while(!condition)
            {
                foreach (Item item in _items.Values)
                {
                    if (item.Type == type)
                    {
                        _items.Remove(item.Name);
                        condition = true;
                        break;
                    }
                }
            }
        }

        public void RemoveAllItemTypes(ItemType[] types)
        {
            foreach (ItemType type in types)
            {
                RemoveItemType(type);
            }
        }

        public bool HasItemType(ItemType type)
        {
            foreach (Item item in _items.Values)
            {
                if (item.Type == type)
                {
                    return true;
                }
            }
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
                Put(item);
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

        public string PrintInventory()
        {
            string print = string.Empty;

            if (_items.Count <= 0)
            {
                return print = "You have no items in your Inventory\n";
            } else 
            { 
                print += "You have the following in your inventory:\n";
                foreach (string item in _items.Keys)
                {
                
                    if (_items.Count == 1)
                    {
                        print += "a " + item + "!\n"; 
                    } 
                    else if (_items.Count > 1)
                    {
                        if (_items.Keys.Last().Equals(item))
                        {
                            print += "and a " + item + "!\n";
                        } else { 
                        print += "a " + item + "\n";
                        }
                    } 
                    else 
                    { 
                    print += "a " + item + "\n";
                    }
                }
            }
            return print;
            
        }
    }
}
