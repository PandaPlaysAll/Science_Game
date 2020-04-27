using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Scientist scientist = new Scientist();
            Experiment experiment1 = new Cybernetics();
            Experiment experiment2 = new Transgenesis();

            scientist.Adopt(experiment2);
            scientist.Perform();
            scientist.Perform();
            scientist.Adopt(experiment2);
            scientist.Perform();
            scientist.Adopt(experiment2);
            scientist.Perform();
            scientist.Adopt(experiment2);
            scientist.Perform();
            scientist.Adopt(experiment2);
            scientist.Perform();
            scientist.Adopt(experiment1, "smart");
            scientist.Perform();
            scientist.Adopt(experiment1, "smart");
            scientist.Perform("smart");
            scientist.Perform("smart");
            Console.ReadKey();
        }
    }
}
