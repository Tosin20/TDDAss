using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAss;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2.0d,2.0d,2.0d)]
        [DataRow(4.0d, 4.0d, 8.0d)]
        [DataRow(100.0d, 100.0d, 5000.0d)]
        public void AreaTest(double d1,double d2, double result)
        {
            var cal = new Calculator();
            var area = cal.Area(d1, d2);
            Assert.AreEqual(area, result);

        }
    }
}