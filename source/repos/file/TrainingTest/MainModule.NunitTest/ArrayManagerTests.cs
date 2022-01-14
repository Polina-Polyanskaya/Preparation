using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModule.NunitTest
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

        [TestCase(new int[]{ 3, 8, 1, 21, 5 },21)]
        public void FindMax_PositiveElements_Test(int[] ar, int expected)
        {
            int actual = ArrayManager.FindMax(ar);

            Assert.AreEqual(expected, actual);
        }
    }
}
