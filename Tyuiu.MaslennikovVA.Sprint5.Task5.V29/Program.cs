using Tyuiu.MaslennikovVA.Sprint5.Task5.V29.Lib;
namespace Tyuiu.MaslennikovVA.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Масленников В.А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Масленников Владислав Александрович | ИИПб-24-2               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор значений. Найти минимальное целое число   *");
            Console.WriteLine("* в файле, которое является двузначным числом. Полученный результат       *");
            Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков    *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V0.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное целое двухзначное число: " + res);

            Console.ReadKey();
        }
    }
}