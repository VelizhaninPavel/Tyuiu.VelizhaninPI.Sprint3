using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint3.Task1.V8.Lib;

namespace Tyuiu.VelizhaninPI.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries1()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 18.980;

            Assert.AreEqual(wait, res);

        }
    }
}
