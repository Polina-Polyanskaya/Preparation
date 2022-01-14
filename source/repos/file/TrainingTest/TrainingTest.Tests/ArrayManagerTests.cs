using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MainModule.Tests
{
    [TestClass]
    public class ArrayManagerTests
    {
        [TestMethod]
        public void FindMax_PositiveElements_Test()
        {
            int[] ar = { 3, 8, 1, 21, 5 };
            int expected = 21;

            int actual = ArrayManager.FindMax(ar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMax_NegativeElements_Test()
        {
            int[] ar = { -3, -8, -21, -5 };
            int expected = -3;

            int actual = ArrayManager.FindMax(ar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]// Exception - ошибка
        public void FindMax_NullArray_ExpectedException()
        {
            int[] ar = null;
            int actual = ArrayManager.FindMax(ar);
        }

        [TestMethod] //3.34, 3.33 проходит, 3.32 нет
        public void GetAverage_PositiveElements_Test()
        {
            int[] ar = { 2,5,3};
            double expected = 3.33;

            double actual = ArrayManager.GetAverage(ar);

            Assert.AreEqual(expected, actual,0.01);
        }
    }
}
