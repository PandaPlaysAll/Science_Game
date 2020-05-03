 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    //constructor
    public class Potion : GameObject
    {
        //fields
        private PotionType _type;

        //constructor
        public Potion(string name, string desc, PotionType type) : base(name, desc)
        {
            _type = type;
        }

        //methods
        public string PrintStringRequirements(PotionType type)
        {
            string message = string.Empty;
            switch(type)
            {
                case PotionType.Buff_Buff:
                    message += "Water + Steak";
                    break;
                case PotionType.Dark_Matter:
                    message += "ember, bone and mushroom";
                    break;
                case PotionType.Healthy_Wealthy:
                    message += "Mushroom, water,ember,bone and mush";
                    break;
                case PotionType.Light_Furry:
                    message += "ember, bone, water,steak";
                    break;
                case PotionType.Posion_Ivy:
                    message += "mush, ivy, water, bone";
                    break;
                default:
                    break;
            }
            return message;
        }

        public ItemType[] PrintPotionTypeRequirement(PotionType type) //needs to be changed to allow static way for the class. Simplify needed
        {
            string message = string.Empty;
            switch (type)
            {
                case PotionType.Buff_Buff:
                    return new ItemType[] { ItemType.water, ItemType.steak, };
                case PotionType.Dark_Matter:
                    return new ItemType[] { ItemType.ember, ItemType.bone, ItemType.mushroom, };
                case PotionType.Healthy_Wealthy:
                    return new ItemType[] { ItemType.water, ItemType.bone, ItemType.ember, ItemType.mushroom,};
                case PotionType.Light_Furry:
                    return new ItemType[] { ItemType.water, ItemType.steak, ItemType.ember, ItemType.bone, };
                case PotionType.Posion_Ivy:
                    return new ItemType[] { ItemType.water, ItemType.steak, ItemType.bone, ItemType.ivy, };
                default:
                    break;
            }
            return null;
        }

        //property
        public PotionType Type
        {
            get { return _type; }
        }

    }
    
}

