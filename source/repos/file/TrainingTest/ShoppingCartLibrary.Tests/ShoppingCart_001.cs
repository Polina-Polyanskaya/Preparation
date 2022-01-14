using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class ShoppingCart_001
    {
        private ShoppingCart shoppingCart;
        private Item item;

        //запуск перед стартом каждого тестирующего метода
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            item=new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            shoppingCart = new ShoppingCart();
            shoppingCart.Add(item);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            shoppingCart.Dispose();
        }

        [TestMethod]
        public void ShoppingCart_AddItem_ContainsItem()
        {
            CollectionAssert.Contains(shoppingCart.Items, item);
        }

        [TestMethod]
        public void ShoppingCart_RemoveItem_Empty()
        {
            int expected = 0;

            shoppingCart.Remove(0);

            int actual = shoppingCart.Count;

            Assert.AreEqual(expected,actual);
        }
    }
}
