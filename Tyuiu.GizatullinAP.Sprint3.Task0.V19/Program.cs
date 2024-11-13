using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.GizatullinAP.Sprint3.Task0.V19.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task0.V19
{
    class Program
    {
        static void Main(string[] args)

        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Гизатуллин А. П. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Варинант #19                                                            *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович | ИСПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение    *");
            Console.WriteLine("*ряда по формуле                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadLine();
        }
    }
}