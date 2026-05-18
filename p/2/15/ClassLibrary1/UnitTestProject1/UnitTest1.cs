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
            Arr actual = new Arr(10, -5, 4, 10);
            ++actual;
            Arr expected = new Arr(11, -4, 5, 11);
            Assert.AreEqual<Arr>(expected, actual, "Результат не соответствует");
        }

        [TestMethod]
        public void TestMethodLabTask1()
        {
            Arr actual = new Arr(1, 10, 5, 3, 7, 8, 9, 10);
            actual.LabTask();
            Arr expected = new Arr(1, 10, 5, 9, 7, 8, 3, 10);
            Assert.AreEqual<Arr>(expected, actual, "Тест не пройден!");
        }

        [TestMethod]
        public void TestMethodLabTask2()
        {
            Arr actual = new Arr(1, 10, 5, 3, 7, 8, 0, 10);
            actual.LabTask();
            Arr expected = new Arr(1, 10, 5, 3, 7, 8, 0, 10);
            Assert.AreEqual<Arr>(expected, actual, "Тест не пройден!");
        }
    }
}
