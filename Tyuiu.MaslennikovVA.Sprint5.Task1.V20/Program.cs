using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaslennikovVA.Sprint5.Task1.V20.Lib;

namespace Tyuiu.MaslennikovVA.Sprint5.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Масленников В.А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Масленников Владислав Александрович | ИИПб-24-2               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, (произвести табулирование) f(x) на заданном диапазоне     *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении     *");
            Console.WriteLine("* на ноль вернуть значение 0. результат сохранить в текстовый файл        *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить  *");
            Console.WriteLine("* до двух знаков после запятой.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Функция: ");
            Console.WriteLine("  5x+2.5");
            Console.WriteLine(" ---------   + 2x + cos(x)");
            Console.WriteLine(" sin(x)+3");
            Console.WriteLine();
            Console.WriteLine(" startValue = " + startValue);
            Console.WriteLine(" stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}