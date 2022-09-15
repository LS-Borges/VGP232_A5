using Assignment5;
using NUnit.Framework;

namespace InventoryTest
{
    public class Tests
    {
        private Inventory inventory;
        private Item item1;
        private Item item2;
        private Item item3;

        [SetUp]
        public void Setup()
        {
            inventory = new Inventory(2);
            item1 = new Item("item1", 1, ItemGroup.Equipment);
            item2 = new Item("item2", 1, ItemGroup.Equipment);
            item3 = new Item("item3", 1, ItemGroup.Key);
        }

        [Test]
        public void RemoveItem()
        {
            // add item
            Assert.IsTrue(inventory.AddItem(item1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);

            //Remove item
            Assert.IsTrue(inventory.TakeItem(item1));
            Assert.AreEqual(inventory.ListAllItems().Count, 0);

            // add item
            Assert.IsTrue(inventory.AddItem(item1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);

            //Remove item that doesnt exist
            Assert.IsFalse(inventory.TakeItem(item2));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);
        }

        [Test]
        public void AddItem()
        {
            Assert.IsTrue(inventory.AddItem(item1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);

            Assert.IsTrue(inventory.AddItem(item2));
            Assert.AreEqual(inventory.ListAllItems().Count, 2);

            Assert.IsFalse(inventory.AddItem(item3));
            Assert.AreEqual(inventory.ListAllItems().Count, 2);
        }

        [Test]
        public void Reset()
        {
            Assert.IsTrue(inventory.AddItem(item1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);

            inventory.Reset();
            Assert.AreEqual(inventory.ListAllItems().Count, 0);
            Assert.AreEqual(inventory.AvailableSlots, inventory.MaxSlots);
        }
    }
}