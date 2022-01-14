using NUnit.Framework;
using System;

namespace MainModule.NunitLiteTest
{
    [TestFixture]
    public class ArrayManagerTests
    {
        [Test]
        public void FindMax_PositiveElements_Test()
        {
            int[] ar = { 3, 8, 1, 21, 5 };
            int expected = 21;

            int actual = ArrayManager.FindMax(ar);

            Assert.AreEqual(expected, actual);
        }
    }
}
