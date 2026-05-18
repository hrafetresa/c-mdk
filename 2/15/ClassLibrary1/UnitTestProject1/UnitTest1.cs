using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIncrement()
        {
            Arr Actual = new Arr(10, -5, 4, 10);
            ++Actual;
            Arr Expected = new Arr(11, -4, 5, 11);
            Assert.AreEqual<Arr>(Expected, Actual, "Результат не соответствует");
        }
    }
}
