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
        

        public GameObject(string name = "Unidentified", string desc = "Unidentified") 
        {
            _name = name;
            _desc = desc;
            _charactersExisting++;
            

        }
        public GameObject() : this("No Name", "No Desc") { }
        public bool AreYou(string name)
        {
            if (_name.ToLower() == name.ToLower())
                return true;
            return false;
     
        }
        public string Name
        {
            get { return _name; }
        }

    }
}
