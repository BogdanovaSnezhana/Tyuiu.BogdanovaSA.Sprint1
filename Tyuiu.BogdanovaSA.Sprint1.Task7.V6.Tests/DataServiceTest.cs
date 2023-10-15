using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint1.Task7.V6.Library;

namespace Tyuiu.BogdanovaSA.Sprint1.Task7.V6.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataService();
            double x = 1;
            double y = 2;
            double z = 3;
            double wait = 0.25;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(wait, res);


        }
    }
}
