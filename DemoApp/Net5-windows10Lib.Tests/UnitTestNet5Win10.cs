using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Net5_windows10Lib.Tests
{
    [TestClass]
    public class UnitTestNet5Win10
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            var path = Path.Combine(TestContext.TestRunDirectory, "net5wintest.txt");
            var sut = new ClassNet5Win10();

            sut.WriteHelloWorld(path);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
