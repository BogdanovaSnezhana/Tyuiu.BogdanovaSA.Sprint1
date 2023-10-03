﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint1.Task1.V0.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double a = 3.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(-1, res);

        }
    }
}
