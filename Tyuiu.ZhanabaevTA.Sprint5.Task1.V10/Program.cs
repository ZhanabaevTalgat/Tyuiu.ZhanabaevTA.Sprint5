using Tyuiu.ZhanabaevTA.Sprint5.Task1.V10.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = (2cos(x)+2)/(2x-1) +cos(x)-5x+3  (произвести       *");
            Console.WriteLine("* табулирование) на заданном диапазоне c шагом 1. Произвести проверку     *");
            Console.WriteLine("* деления на ноль. При делении на 0 вернуть значение 0. Результат         *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в   *");
            Console.WriteLine("* в таблицу. Значения округлить до 2 знаков после запятой                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("диапазон: [-5;5]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
