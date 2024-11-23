using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.ZhanabaevTA.Sprint5.Task0.V30;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask0.txt");

            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);

            y = (Math.Round(y, 3));

            File.WriteAllText(filePath, Convert.ToString(y));
            return filePath;
        }
    }
}