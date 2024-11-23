using Tyuiu.ZhanabaevTA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все строчные *");
            Console.WriteLine("* русские буквы на заглавные. Полученный результат сохранить в файл.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}
