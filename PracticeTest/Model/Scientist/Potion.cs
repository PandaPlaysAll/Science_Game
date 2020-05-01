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

        public PotionType Type
        {
            get { return _type; }
        }
    }
}
