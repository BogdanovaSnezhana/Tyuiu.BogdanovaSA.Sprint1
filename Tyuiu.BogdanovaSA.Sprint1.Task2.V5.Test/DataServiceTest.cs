﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint1.Task2.V5.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual(4, res);
        }
    }
}
