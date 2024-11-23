using System.IO;
using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(filePath);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length/rows;

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        matrix[i,j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i,j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i,j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(filePath, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, str);
                }

                str = "";
            }

            return filePath;
        }
    }
}
