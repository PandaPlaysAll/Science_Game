using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class Transgenesis : Experiment
    {
        //fields
        private int _count;

        //constructor
        public Transgenesis()
        {
            _count = 0;
        }
        //methods
        public override void Conduct()
        {
            _count++;
            switch (_count)
            {
                case 1:
                    Console.WriteLine("Mutant Power!");
                    break;
                case 2:
                    Console.WriteLine("I feel dizzy.");
                    break;
                case 3:
                    Console.WriteLine("Gloop.");
                    break;
                default:
                    break;
            }
        }

    }
}
