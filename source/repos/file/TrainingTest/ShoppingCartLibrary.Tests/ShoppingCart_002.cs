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
    public class ShoppingCart_002
    {
        private static ShoppingCart shoppingCart;

        //запуск перед первым тестирующимся методом - один раз
        [ClassInitialize]
        public static void ClassInitialize()
        {
            Debug.WriteLine("Test Initialize");
            Item item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            shoppingCart = new ShoppingCart();
            shoppingCart.Add(item);
        }

        //запуск после последнего тестирующегося метода - один раз
        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            shoppingCart.Dispose();
        }

        [TestMethod]
        public static void ShoppingCart_AddItem_ContainsItem()
        {
            int expected = shoppingCart.Items.Count + 1;

            shoppingCart.Add(new Item() { Name = "Test", Quantity = 1 });

            Assert.AreEqual(expected, shoppingCart.Count);
        }

        [TestMethod]
        public static void ShoppingCart_RemoveItem_Empty()
        {
            int expected = 0;

            shoppingCart.Remove(0);

            int actual = shoppingCart.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
