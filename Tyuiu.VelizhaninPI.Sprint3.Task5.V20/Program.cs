using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint3.Task5.V20.Lib;
using Tyuiu.VelizhaninPI.Sprint3.Task5.V20.Test;

namespace Tyuiu.VelizhaninPI.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*    _3  _6                                                               *");
            Console.WriteLine("*   |   |  (x/sin(x))^2, при х = 5                                        *");
            Console.WriteLine("*   /_  /_                                                                *");
            Console.WriteLine("*   i=1 k=1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("  ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            Console.WriteLine("Значение x = " + x);
            Console.WriteLine("Начало шага 1 = " + startValue1);
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            Console.WriteLine("Начало шага 2 = " + startValue2);
            Console.WriteLine("Конец шага 2 = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма сумм ряда: " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadLine();
        }
    }
}
