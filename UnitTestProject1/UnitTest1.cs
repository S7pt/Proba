using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            int b = 5;
            int c = 6;
            int result_a = ConsoleApp1.Program.Swapper(a, c);
            int result_b = ConsoleApp1.Program.Swapper(b, a);
            int result_c = ConsoleApp1.Program.Swapper(c, b);
            Assert.AreEqual(6, result_a);
            Assert.AreEqual(4, result_b);
            Assert.AreEqual(5, result_c);

        }
    }
}