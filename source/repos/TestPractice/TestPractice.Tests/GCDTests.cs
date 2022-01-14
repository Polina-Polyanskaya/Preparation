using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPractice.Tests
{
    [TestClass]
    public class GCDTests
    {
        GCD gcd;

        [TestInitialize]
        public void GcdInitialize()
        {
            gcd=new GCD();
        }

        //Equal
        [TestMethod]
        public void Gcd_BothPositiveAndEqual_FirstReturned()
        {
            long expected = gcd.Gcd(5, 5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "5 gcd 5 not equals 5");
        }

        [TestMethod]
        public void Gcd_BothNegativeAndEqual_ModuleFirstReturned()
        {
            long expected = gcd.Gcd(-5, -5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "-5 gcd -5 not equals 5");
        }

        //Zero
        [TestMethod]
        public void Gcd_BothZero_ZeroReturned()
        {
            long expected = gcd.Gcd(0, 0);

            long actual = 0;

            Assert.AreEqual(expected, actual, "0 gcd 0 not equals 0");
        }

        [TestMethod]
        public void Gcd_FirstZeroSecondPositive_SecondReturned()
        {
            long expected = gcd.Gcd(0, 5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "0 gcd 5 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstPositiveSecondZero_FirstReturned()
        {
            long expected = gcd.Gcd(5, 0);

            long actual = 5;

            Assert.AreEqual(expected, actual, "5 gcd 0 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstZeroSecondNegative_ModuleSecondReturned()
        {
            long expected = gcd.Gcd(0, -5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "0 gcd -5 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstNegativeSecondZero_ModuleFirstReturned()
        {
            long expected = gcd.Gcd(-5, 0);

            long actual = 5;

            Assert.AreEqual(expected, actual, "-5 gcd 0 not equals 5");
        }

        //Opposite and Equal
        [TestMethod]
        public void Gcd_FirstPositiveSecondNegativeModuleEquals_ModuleFirstReturned()
        {
            long expected = gcd.Gcd(-5, 5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "-5 gcd 5 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstNegativeSecondPositiveModuleEquals_FirstReturned()
        {
            long expected = gcd.Gcd(5, -5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "5 gcd -5 not equals 5");
        }

        //Not one and gcd equals 1
        [TestMethod]
        public void Gcd_BothPositiveNotEqualGcdIs1_1Returned()
        {
            long expected = gcd.Gcd(6, 5);
         
            long actual = 1;

            Assert.AreEqual(expected, actual, "6 gcd 5 not equals 1");
        }

        [TestMethod]
        public void Gcd_FirstPositiveSecondNegativeNotEqualGcdIs1_1Returned()
        {
            long expected = gcd.Gcd(6, -5);

            long actual = 1;

            Assert.AreEqual(expected, actual, "6 gcd -5 not equals 1");
        }

        [TestMethod]
        public void Gcd_FirstNegativeSecondPositiveNotEqualGcdIs1_1Returned()
        {
            long expected = gcd.Gcd(-6, 5);

            long actual = 1;

            Assert.AreEqual(expected, actual, "-6 gcd 5 not equals 1");
        }

        [TestMethod]
        public void Gcd_BothNegativeNotEqualGcdIs1_1Returned()
        {
            long expected = gcd.Gcd(-6, -5);

            long actual = 1;

            Assert.AreEqual(expected, actual, "-6 gcd -5 not equals 1");
        }

        //Gcd not 1
        [TestMethod]
        public void Gcd_BothPositiveNotEqualGcdNot1_GcdReturned()
        {
            long expected = gcd.Gcd(25, 5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "25 gcd 5 not equals 5");
        }

        [TestMethod]
        public void Gcd_BothNegativeNotEqualGcdNot1_ModuleGcdReturned()
        {
            long expected = gcd.Gcd(-25, -5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "-25 gcd -5 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstPositiveSecondNegativeNotEqualGcdNot1_ModuleGcdReturned()
        {
            long expected = gcd.Gcd(25, -5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "25 gcd -5 not equals 5");
        }

        [TestMethod]
        public void Gcd_FirstNegativeSecondPositiveNotEqualGcdNot1_ModuleGcdReturned()
        {
            long expected = gcd.Gcd(-25, 5);

            long actual = 5;

            Assert.AreEqual(expected, actual, "-25 gcd 5 not equals 5");
        }

        //One and zero
        [TestMethod]
        public void Gcd_FirstZeroSecondOne_1Returned()
        {
            long expected = gcd.Gcd(0, 1);

            long actual = 1;

            Assert.AreEqual(expected, actual, "0 gcd 1 not equals 1");
        }

        [TestMethod]
        public void Gcd_FirstOneSecondZero_1Returned()
        {
            long expected = gcd.Gcd(1, 0);

            long actual = 1;

            Assert.AreEqual(expected, actual, "1 gcd 0 not equals 1");
        }

        [TestMethod]
        public void Gcd_BothOne_1Returned()
        {
            long expected = gcd.Gcd(1, 1);

            long actual = 1;

            Assert.AreEqual(expected, actual, "1 gcd 1 not equals 1");
        }

        [TestMethod]
        public void Gcd_FirstZeroSecondMinusOne_1Returned()
        {
            long expected = gcd.Gcd(0, -1);

            long actual = 1;

            Assert.AreEqual(expected, actual, "0 gcd -1 not equals 1");
        }

        [TestMethod]
        public void Gcd_FirstMinusOneSecondZero_1Returned()
        {
            long expected = gcd.Gcd(-1, 0);

            long actual = 1;

            Assert.AreEqual(expected, actual, "-1 gcd 0 not equals 1");
        }

        [TestMethod]
        public void Gcd_BothMinusOne_1Returned()
        {
            long expected = gcd.Gcd(-1, -1);

            long actual = 1;

            Assert.AreEqual(expected, actual, "-1 gcd 1 not equals 1");
        }

        //Boarder values
        [TestMethod]
        public void Gcd_FirstMaxValue_GcdReturned()
        {
            long expected = gcd.Gcd(long.MaxValue, 5);

            long actual = gcd.Gcd(5, long.MaxValue);

            Assert.AreEqual(expected, actual, "long MaxValue gcd 5 not equals 5 gcd long MaxValue");
        }

        [TestMethod]
        public void Gcd_FirstMinValue_GcdReturned()
        {
            long expected = gcd.Gcd(long.MinValue, long.MinValue);

            long actual = long.MinValue;

            Assert.AreEqual(expected, actual, "long MinValue gcd long MinValue not equals long MinValue");
        }

        int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        //Fibonachi with big n
        [TestMethod]
        public void Gcd_Fibonachi_GcdReturned()
        {
            long expected = gcd.Gcd(46, 45);

            long actual = gcd.Gcd(45, 46);

            Assert.AreEqual(expected, actual, "Fibonachi(46) gcd Fibonachi(45) not equals Fibonachi(45) gcd Fibonachi(46)");
        }
    }
}