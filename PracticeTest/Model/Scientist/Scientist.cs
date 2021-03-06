﻿using System;
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

        //fields
        private List<Potion> _potions;
        
        //constructor
        public Scientist(string name, string desc) : base(name, desc)
        {
            
            Damage = 5;
            _potions = new List<Potion>();
           

        }

        public Scientist() : this ("Basic Scientist", "Basic Scientist Description")
        {
            
        }

        //methods / Implicit normal attack
        public void Attack(Character player,PotionType potionType)
        {
            bool completed = false;
            int dmg = 0;
            while (!completed) { 
                if (_potions.Count > 0)
                {
                    foreach (Potion p in Potion)
                    {    
                        switch (potionType)
                        {
                            case PotionType.Healthy_Wealthy:
                                AdvHeal(p);
                                Console.WriteLine("{0} healed up to {1}", this.Name, Health);
                                dmg += 10;
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
                } else { completed = true; }
            } 
            

            if (SwordCount >= 3)
            {
                Inventory.RemoveItemType(ItemType.sword);
            }

            if (Inventory.HasItemType(ItemType.sword))
            {
                dmg += 10;
                SwordCount++;
                Console.WriteLine("{0} attacked {1} with a sword!, {2} has {3} HP left", Name, player.Name, player.Name, player.Health);
            }
            else
            {
                Console.WriteLine("{0} attacked {1}, {2} has {3} HP left", Name, player.Name, player.Name, player.Health);
            }
            player.Health -= (dmg + Damage);
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

     

        public bool FormPotion(PotionType potion, string name, string desc = "none") 
        {
         //   Potion _fakePotion;
           // _fakePotion = new Potion("fake", "fake", PotionType.Buff_Buff);
            

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
                    return true;
                case PotionType.Dark_Matter:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.ember,
                        ItemType.bone,
                        ItemType.mushroom,
                    })) 
                     { 
                        Potion.Add(new Potion(name, desc, potion));
                        return true;
                     }
                    return false;
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
                    return true;
                case PotionType.Light_Furry:
                    if (preparePotion(new ItemType[]
                    {
                        ItemType.ember,
                        ItemType.bone,
                        ItemType.water,
                        ItemType.steak,
                    })) {
                        Potion.Add(new Potion(name, desc, potion));}
                    return true;
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
                    return true;
                default:
                    return false;
            }


        }

        public void RemovePotionType(PotionType type)
        {
            bool completed = false;
            while (!completed)
            {
                foreach (Potion p in Potion)
                {
                    if (p.Type == type)
                    {
                        Potion.Remove(p);
                        completed = true;
                        break;
                    }
                }
            }
        }


        public bool preparePotion(ItemType[] types)
        {

            if (Inventory.HasAllItemTypes(types))
            {
                Inventory.RemoveAllItemTypes(types);
                return true;
            }
            return false;
        }

        public List<Potion> Potion
        {
            get { return _potions; }
        }

        public bool PotionListNotEmpty()
        {
            if (Potion.Count != 0)
            { 
                return true;
            }
            return false;
        }


        public string PrintPotions()
        {
            string print = string.Empty;
            if (_potions.Count < 1)
            {
                return print = "You have no potions\n";
            }
            else
            {
                print += "You have the following potions:\n";
                foreach (Potion item in _potions)
                {
                    string normal = "Potion name: " + "'" + item.Name + "'" + ".\nItem Type: " + item.Type + ".\n";
                    if (_potions.Count == 1)
                    {
                        print += normal;
                    }
                    else if (_potions.Count > 1)
                    {
                        if (_potions.Last().Equals(item))
                        {
                            print += normal;
                        } 
                        else
                        {
                            print += normal;
                        }
                    }
                    else
                    {
                        print += normal;
                    }
                }
            }
            return print;
        }



    }
}
