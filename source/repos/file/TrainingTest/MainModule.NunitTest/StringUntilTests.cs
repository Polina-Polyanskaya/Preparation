using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.NunitTest
{
    [TestFixture]
    public class StringUntilTests
    {
        [TestCase("123gg",6)]
        [TestCase("hello", 0)]
        [TestCase("55", 10)]
        public void GetSumNumberTest(string text, int expected)
        { 

            int actual = StringUtil.GetSumNumber(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
