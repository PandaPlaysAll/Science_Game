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


    public class InventoryTests
    {
        //declaration
        private Inventory _inventory;
        private Inventory _inventory2;
        private Item _item;
        private Item _item2;
        private Item _item3;

        [SetUp]
        public void SetUp()
        {
            _inventory = new Inventory();
            _inventory2 = new Inventory();
            _item = new Item("Shovel", "Metal Shovel", ItemType.sword);
            _item2 = new Item("Mushy", "Yummy mushroom", ItemType.mushroom);
            _item3 = new Item("Ember", "Charcoal Ember", ItemType.ember);
        }

        [Test]
        public void Inventory_Test_Put_Item()
        {
            _inventory.Put(_item);
            Assert.IsTrue(_inventory.HasItem("Shovel"));
        }

        [Test]
        public void Inventory_Test_Take_Item()
        {
            _inventory.Put(_item);
            _inventory.Take("Shovel");
            Assert.IsFalse(_inventory.HasItem("Shovel"));
        }


        [Test]
        public void Inventory_Test_Has_All_Items()
        {
            _inventory.Put(_item);
            _inventory.Put(_item2);
            Assert.IsTrue(_inventory.HasItems(new string[] { "Shovel", "Mushy" }));
        }

        [Test]
        public void Inventory_Test_Has_All_Item_Types_Are_Valid()
        {
            _inventory.Put(_item);
            _inventory.Put(_item2);
            _inventory.Put(_item3);
            Assert.IsTrue(_inventory.HasAllItemTypes(new ItemType[] {
                ItemType.sword,
                ItemType.mushroom,
                ItemType.ember,
            }));
        }

        [Test]
        public void Inventory_Test_All_Item_Types_Invalid()
        {
            _inventory.Put(_item);
            _inventory.Put(_item2);
            Assert.IsFalse(_inventory.HasAllItemTypes(new ItemType[] {
                ItemType.sword,
                ItemType.mushroom,
                ItemType.ember,
            }));
        }

        //test has item type

        //test removeitemtype

        //test remove all item types



        [Test]
        public void Inventory_Test_Print_Inventory_Multiple_Items()
        {
            _inventory.Put(_item);
            _inventory.Put(_item2);
            string txt = "You have the following in your inventory:\na Shovel\nand a Mushy!\n";
            Assert.AreEqual(_inventory.PrintInventory(), txt);
        }

        [Test]
        public void Inventory_Test_Print_Inventory_One_Item()
        {
            _inventory.Put(_item);
            string txt = "You have the following in your inventory:\na Shovel!\n";
            Assert.AreEqual(_inventory.PrintInventory(), txt);
        }


        [Test]
        public void Inventory_Test_Print_Inventory_No_Items_In_Inventory()
        {
            TestContext.WriteLine(_inventory.PrintInventory());
           
            string txt = "You have no items in your Inventory\n";
            Assert.AreEqual(_inventory.PrintInventory(), txt);
        }
    }
}
