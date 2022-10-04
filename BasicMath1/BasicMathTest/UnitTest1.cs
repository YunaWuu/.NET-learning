using BasicMath1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MymathCalc calc = new MymathCalc();
            double res = calc.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MymathCalc calc = new MymathCalc();
            double res = calc.Substract(20, 10);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MymathCalc calc = new MymathCalc();
            double res = calc.Divide(20, 10);
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MymathCalc calc = new MymathCalc();
            double res = calc.Multiply(20, 10);
            Assert.AreEqual(res, 200);
        }
    }
}
