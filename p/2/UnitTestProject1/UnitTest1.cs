using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = { -1, 2, 3, -2, 0, 5 };
            double[] expected = { -1, 5, 0, -2, 3, 2 };
            double[] actual = MyArray.ReversePositive(arr);
            Assert.AreEqual(expected, actual, "Тест не пройден!");
        }
    }
}
