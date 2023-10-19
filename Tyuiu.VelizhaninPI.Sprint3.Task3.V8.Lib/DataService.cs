using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VelizhaninPI.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    result += ch;
                }
            }

            int res = Int32.Parse(result);
            return res;
        }
    }
}
