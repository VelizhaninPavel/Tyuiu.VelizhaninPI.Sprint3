using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint3.Task2.V16.Lib;

namespace Tyuiu.VelizhaninPI.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultiplySeries()
        {

            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
