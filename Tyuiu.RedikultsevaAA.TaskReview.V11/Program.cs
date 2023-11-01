using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.TaskReview.V11.Lib;

namespace Tyuiu.RedikultsevaAA.TaskReview.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт-Review | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт-Review                                                              *");
            Console.WriteLine("* Вариант #20                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:              *");
            Console.WriteLine("*                    sin(x)                                                  *");
            Console.WriteLine("*  F(x) = cos(x) + --------- - 4x                                            *");
            Console.WriteLine("*                    2 - 2x                                                  *");
            Console.WriteLine("* (провести табулирование) f(x) на заданном диапозоне [-5;5] с шагом 1       *");
            Console.WriteLine("* Произвести проверку на ноль вернуть значение 0. Значения занести в массив. *");
            Console.WriteLine("* Значения округлять до двух знаков после запятой.                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(x)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    | {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+---------+---------+");

            Console.ReadKey();
        }
    }
}
