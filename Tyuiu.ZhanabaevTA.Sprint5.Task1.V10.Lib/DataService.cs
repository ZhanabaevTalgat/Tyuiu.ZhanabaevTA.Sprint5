using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(filePath);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            { 
                if (2 * x - 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                };
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(filePath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, strY);
                }
            }

            return filePath;
        }
    }
}
