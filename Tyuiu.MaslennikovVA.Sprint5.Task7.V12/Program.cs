using Tyuiu.MaslennikovVA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.MaslennikovVA.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Масленников В.А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Масленников Владислав Александрович | ИИПб-24-2               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файлв котором есть набор символьных данных.Заменить все строчные    *");
            Console.WriteLine("* русские буквы на заглавные.Полученный результат сохранить в файл        *");
            Console.WriteLine("* OutPutDataFileTask7V12.txt.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V0.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
           
            Console.WriteLine("Измененная строка: " + res);

            Console.ReadKey();
        }
    }
}