using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint1.Task4.V10.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task4V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            double x = 2;
            double y = 3;
            double wait = 0,125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
