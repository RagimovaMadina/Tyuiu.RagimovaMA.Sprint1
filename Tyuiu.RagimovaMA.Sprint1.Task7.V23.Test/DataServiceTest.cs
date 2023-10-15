using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint1.Task7.V23.Lib;

namespace Tyuiu.RagimovaMA.Sprint1.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = Math.Round(1.2651, 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
