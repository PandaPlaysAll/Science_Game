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
    public class Scientist
    {
        //fields
        private Dictionary<string, Experiment> _project;

        //constructor
        public Scientist()
        {
            _project = new Dictionary<string, Experiment>();
            

        }

        //methods
        public void Adopt(Experiment project, string name)
        {
            if (project is Cybernetics)
            {
                _project[name] = project;
            }
            else if (project is Transgenesis)
            {
                _project[name] = project;
            }
        }

        public void Adopt(Experiment project) 
        {
            Random number = new Random();
            string name = Convert.ToString(number.Next(1, 100));
            if (project is Cybernetics)
            {
                _project[name] = project;
            }
            else if (project is Transgenesis)
            {
                _project[name] = project;
            }

        }
      

        public void Perform(string experiment) 
        {
            //Execute the project stored in the Experiment field
            if (IsPrepared(experiment))
            {
                _project[experiment].Conduct();
                _project[experiment] = null;
                Console.WriteLine("Eureka!");
            }
            else
            {
                Console.WriteLine("Hmmm...");
            }
        }

        public void Perform() 
        {
            string project = _project.Last().Key;
            if (IsPrepared(project)) { 
                _project[project].Conduct();
                _project[project] = null;
                Console.WriteLine("Eureka!");
            }
            else
            {
                Console.WriteLine("Hmmm...");
            }
        }


        //properties
        public bool IsPrepared(string experiment)
        {
            if (_project[experiment] != null)
                return true;
            return false;

        }

        public bool IsPrepared()
        {
            if (_project.Last().Value != null)
                return true;
            return false;

        }

    

    }
}
