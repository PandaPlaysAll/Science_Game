using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest.Model.Scientist
{
    public class PotionExecution
    {
        List<Experiment> _potions;

        public PotionExecution() {


        }

        public void Execute(string spell)
        {
            foreach (Experiment p in _potions)
            {
                if (p.Name.ToLower() == spell)
                {
                    //do something
                }
            }
        }
        //loop through which potion is being used?
        //if specific ones are being used, set user to stunned etc?
    }
}
