using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "н * н";
            DataServiceTest ds = new DataServiceTest();
            string res = ds.WorkWithText(strTest);
            string wait = "нн";
            Assert.AreEqual(wait, res);
        }
    }
}
