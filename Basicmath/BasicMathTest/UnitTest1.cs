using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod1()
        {
            MymathCalc bm = new MymathCalc();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
    }
}
