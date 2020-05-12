using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[5] { -5, 6, 15, 47, -15 };
            int n = 5;
            int result1 = Lab2_04.Program.Min_abs(a, n);
            Assert.AreEqual(1, result1);
            int result2 = Lab2_04.Program.Sum(a, n);
            Assert.AreEqual(15, result2);
        }
    }
}
