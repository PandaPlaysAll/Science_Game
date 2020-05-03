using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public static class GameItems
    {

        //declarations
        private static readonly List<Item> _items;
        private static Random _random;

        static GameItems()
        {
            _random = new Random();
            _items = new List<Item>();
        }

        private static string RandomString(int length)
        {
            string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => pool[_random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }
        public static void PutRandomItem(Character player, int startAmount, int endAmount, int maxEnum)
        {
           // if (p is Scientist)
             //   p.Inventory.Put(_items[random]);

            for (int i = startAmount; i < endAmount; i++)
            {
                string addition = RandomString(5);
                ItemType type = (ItemType)_random.Next(0, maxEnum);
                string name = Convert.ToString(type) + addition;
                _items.Add(new Item(name, name, type));
                if (player.Inventory.HasItem(name))
                {
                    continue;
                } else { 
                player.Inventory.Put(_items.Last());
                }
            }
          
        }
        public static void RandomItem(Character player)
        {
            int percentange = _random.Next(0, 100);

            if (percentange >= 90 && percentange <= 100)
            {
                PutRandomItem(player, 0, 5, 8);
            } else if (percentange < 90 && percentange >= 75)
            {
                PutRandomItem(player, 0, 6, 8);

            } else if (percentange < 75 && percentange >= 50)
            {
                PutRandomItem(player, 0, 4, 5);

            } else
            {
                PutRandomItem(player, 0, 2, 4);
            }
        }
    }
}
