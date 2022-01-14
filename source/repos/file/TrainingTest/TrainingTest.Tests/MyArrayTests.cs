using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.Tests
{
    [TestClass()]
    public class MyArrayTests
    {
        public TestContext TestContext { get; set; }

        MyArray ar;

        [TestInitialize]
        public void Setup()
        {
            int[] a = { 4, 8, 2, 1 };
            ar = new MyArray(a);
        }

        [TestMethod()]
        public void FindMaxTest()
        {
            int expected = 8;
            int actual = ar.FindMax();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TryContext()
        {
            TestContext.WriteLine(TestContext.TestRunDirectory);
            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());
        }

        [TestMethod()]
        public void GetAverageTest()
        {
            TestContext.WriteLine(TestContext.TestName);
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine(TestContext.TestRunDirectory);
            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());
        }
    }
}