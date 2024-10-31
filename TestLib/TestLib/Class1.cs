using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLib
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void test1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void test2()
        {
            Assert.IsTrue(false);
        }
    }
}
