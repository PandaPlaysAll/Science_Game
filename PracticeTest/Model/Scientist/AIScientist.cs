using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest 
{
    public class AIScientist : Scientist
    {
        //constructor
        public AIScientist (string name, string desc, int health) : base (name, desc)
        {
            Health = health; //Allows manual set of Health for bosses...
        }

        public override void Attack(Character player)
        {
            if (Inventory.Count > 0)
                AIFormPotion(); //Automate the formation of Potions if items allow item.
      
            if (PotionListNotEmpty())
            {
                PotionType type = base.Potion.Last().Type; //Automate attacking with a Potion if it exists, add a loop process if list > 1, allow multiple attacks higher the level
                base.Attack(player, type);
            } else 
            { 
            base.Attack(player);
            }
        }

        public void AIFormPotion()
        {
           try { 
                foreach (PotionType type in Enum.GetValues(typeof(PotionType)))
                {
                    base.FormPotion(type, "potion", "potion");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
