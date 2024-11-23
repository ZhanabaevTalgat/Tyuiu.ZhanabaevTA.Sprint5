using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");           

            double y = Math.Round((4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return filePath;
        }
    }
}
