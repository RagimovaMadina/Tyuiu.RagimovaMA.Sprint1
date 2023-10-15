using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint1.Task4.V26.Lib;

namespace Tyuiu.RagimovaMA.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = -1;
            var a = ds.Calculate(x, y);
            Assert.AreEqual(-0.215, a);

        }
    }
}
