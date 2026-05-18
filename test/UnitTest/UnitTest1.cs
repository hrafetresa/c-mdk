using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using test;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = { -1, 12, 3, -2, 0, 5 };
            double[] expected = { -1, 5, 3, -2, 0, 2 };
            CollectionAssert.AreEqual(expected, MyArray.ReversePositive(arr), "Тест не пройден!");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = { -1, 12, 3, -2, 0, 5, 10, 0, -2, 3, 4, -3 }; 
            double[] expected = { -1, 4, 3, -2, 0, 10, 5, 0, -2, 3, 2, -3};
            CollectionAssert.AreEqual(expected, MyArray.ReversePositive(arr), "Тест не пройден!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "В массиве нет положительных!")]
        public void TestMethod3()
        {
            double[] myAr = { -1.2, -9.6, -11.5, -7.8 };
            MyArray.ReversePositive(myAr);
        }
    }
}
