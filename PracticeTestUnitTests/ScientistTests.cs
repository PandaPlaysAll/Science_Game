using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeTest;

namespace PracticeTestUnitTests
{
    [TestFixture]

    
    public class ScientistTests
    {
        //declaration
        private Experiment _experiment1;
        private Experiment _experiment2;
        private Scientist _scientist;
        [SetUp]
        public void SetUp()
        {
            _experiment1 = new Cybernetics(); 
            _experiment2 = new Cybernetics();
            _scientist = new Scientist();
        }

        [Test]
        public void TestHere()
        {
            _scientist.Adopt(_experiment1); 
            _scientist.Perform();
        }
    }
}
