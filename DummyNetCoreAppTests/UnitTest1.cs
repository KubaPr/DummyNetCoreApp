using DummyNetCoreApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DummyNetCoreAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 0);
        }

        [TestMethod]
        public void ReadFileContentShouldBeHelloYellow()
        {
            Assert.AreEqual("hello Yellow!", FileReader.Read());
        }
    }
}
