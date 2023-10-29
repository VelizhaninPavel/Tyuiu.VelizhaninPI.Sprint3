using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VelizhaninPI.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;

            double[] valueArray;
            valueArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Cos(x)/(x - 0.4)) + Math.Sin(x) * 8 * x + 2), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
