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
        private Scientist _scientist;
        private DemonAI _demonAI;
        private Item _item;
        private Item _item2;

        [SetUp]
        public void SetUp()
        {
            _scientist = new Scientist("Jerome", "The Joker");
            _demonAI = new DemonAI("Baby demon", "A small ghost figure with pointy ears");
            _item = new Item("water", "wata", ItemType.water);
            _item2 = new Item("steak", "stk stk", ItemType.steak);
        }

        [Test]
        public void Scientist__Attacks_Werewolf_With_No_Potion_Achieve_5_Attack_Damage()
        {
            _scientist.Attack(_demonAI);
            Assert.AreEqual(_demonAI.Health, 145);
            //Assert.AreEqual(Scientist.Stunned, false);
        }

        [Test]
        public void Invalid_Form_Potion_With_Invalid_Items()
        {
            Assert.IsFalse(_scientist.FormPotion(PotionType.Dark_Matter, "My cool potion", "cool description"));

        }

        [Test]
        public void Valid_Form_Potion_With_Valid_Items()
        {
            _scientist.Inventory.Put(_item);
            _scientist.Inventory.Put(_item2);
            Assert.IsTrue(_scientist.FormPotion(PotionType.Buff_Buff, "Potion o' Love", "cool description"));
            TestContext.WriteLine(_scientist.PrintPotions());
         

        }

        [Test]
        public void Valid_Print_Potion_With_No_Potions()
        {
            _scientist.Inventory.Put(_item);
            _scientist.Inventory.Put(_item2);
            string txt = "You have no potions\n";
            Assert.AreEqual(txt, _scientist.PrintPotions());

        }

        [Test]
        public void Valid_Print_Potion_With_Existing_Potions()
        {
            _scientist.Inventory.Put(_item);
            _scientist.Inventory.Put(_item2);
            _scientist.FormPotion(PotionType.Buff_Buff, "Potion o' Love", "cool description");
            string txt = "You have the following potions:\nPotion name: 'Potion o' Love'.\nItem Type: Buff_Buff.\n";
            Assert.AreEqual(txt, _scientist.PrintPotions());

        }
    }
}
