using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class GameObject
    {
        //fields
        private string _name;
        private string _desc;
        private static int _charactersExisting;

        public  GameObject(string name, string desc) 
        {
            _name = name;
            _desc = desc;
            _charactersExisting++;

        }
        public GameObject() : this("No Name", "No Desc") { }
    }
}
