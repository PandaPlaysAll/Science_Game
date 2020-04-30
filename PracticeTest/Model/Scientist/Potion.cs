using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Potion : GameObject
    {
        private PotionType _type;
        public Potion(string name, string desc, PotionType type) : base(name, desc)
        {
            _type = type;
        }

        public void Execute()
        {
            if (Type == PotionType.Buff_Buff)
            {

            }
            if (Type == PotionType.Dark_Matter)
            {

            }
            if (Type == PotionType.Healthy_Wealthy)
            {

            }
            if (Type == PotionType.Light_Furry)
            {

            }
            if (Type == PotionType.Posion_Ivy)
            {

            }

        }
        public PotionType Type
        {
            get { return _type; }
        }
    }
}
