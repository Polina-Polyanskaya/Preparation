using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary.Tests
{
    [TestClass]
    public class SimpleClassTests
    {
        [TestMethod]
        public void Add_2plus3_5returned()
        {
            SimpleClass instance = new SimpleClass();
            int x = 2, y = 3, expected = 5;

            int actual = instance.Add(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Div_10div2_5returned()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 2, expected = 5;

            int actual = instance.Div(x, y);
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void Div_10div0_ExceptionExpected()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 0;

            int actual = instance.Div(x, y);
        }
    }
}