using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Scientist : Character
    {


        List<Potion> _potions;
        //scientist can only attack with potion

        //constructor
        public Scientist(string name, string desc) : base(name, desc)
        {
        
            
           

        }

        public Scientist() : this ("Basic Scientist", "Basic Scientist Description")
        {
            
        }

        //methods


        public void Attack(Character player,PotionType potionType)
        {
            bool completed = false;
            int dmg = 0;
            while (!completed)
            foreach (Potion p in Potion)
            {    
                switch (potionType)
                {
                    case PotionType.Healthy_Wealthy:
                        AdvHeal(p);
                        Console.WriteLine("{0} healed up to {1}", this.Name, Health);
                        completed = true;
                        break;
                    case PotionType.Dark_Matter:
                        completed = true;
                        break;
                    case PotionType.Posion_Ivy:
                        completed = true;
                        break;
                    case PotionType.Light_Furry:
                        completed = true;
                        break;
                        case PotionType.Buff_Buff:
                        completed = true;
                        break;
                    default:
                        completed = true;
                        break;
                    }
            }
            player.Health -= dmg;
            Console.WriteLine("{0} attacked {1}, {2} has {3} left", Name, player.Name, player.Health);

        }

        public void AdvHeal(Potion p) 
        {
            if (Health != 100)
            {
                if (p.Type == PotionType.Healthy_Wealthy) 
                {
                    Health += 30;
                    Heal();
                    
                }
            }
        }

        public void Heal() 
        {
            Health += 10;
            if (Health > 100)
                Health = 100;
        }

     

        public void FormPotion(PotionType potion, string name, string desc) 
        {

     
            //console.writeline (successfuly made ? switch.case?)
            switch (potion)
           { 
                case PotionType.Buff_Buff:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.water,
                        ItemType.steak,
                    })) { 
                        Potion.Add(new Potion(name, desc, potion));}
                    break;
                case PotionType.Dark_Matter:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.ember,
                        ItemType.bone,
                        ItemType.mushroom,
                    }
                    )) {
                        Potion.Add(new Potion(name, desc, potion));}
                    break;
                case PotionType.Healthy_Wealthy:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.mushroom,
                        ItemType.water,
                        ItemType.ember,
                        ItemType.bone,
                        ItemType.mushroom,
                    }
                    )) {
                        Potion.Add(new Potion(name, desc, potion));}
                    break;
                case PotionType.Light_Furry:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.ember,
                        ItemType.bone,
                        ItemType.water,
                        ItemType.steak,
                    })) {
                        Potion.Add(new Potion(name, desc, potion));}
                    break;
                case PotionType.Posion_Ivy:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.mushroom,
                        ItemType.ivy,
                        ItemType.water,
                        ItemType.bone,
                    })) {
                        Potion.Add(new Potion(name, desc, potion));
                    }
                    break;
                default:
                    break;
            }


        }


        public bool preparePotion(ItemType[] types)
        {
            if (Inventory.HasAllItemTypes(types))
            {
                return true;
            }
            return false;
        }

        public List<Potion> Potion
        {
            get { return _potions; }
        }





    }
}
