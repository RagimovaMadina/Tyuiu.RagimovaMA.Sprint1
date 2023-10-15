using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint1.Task3.V15.Lib;

//

namespace Tyuiu.RagimovaMA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 2;
            double s = 2;
            double t = 2;
            double wait = 10;
            var res = ds.DistanceOverTime(v1, v2, s, t);
            Assert.AreEqual(wait, res);
        }
    }
}
