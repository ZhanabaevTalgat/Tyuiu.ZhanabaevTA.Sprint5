using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] num = line.Split(' ');
                    for (int i = 0; i < num.Length; i++)
                    {
                        num[i] = num[i].Replace('.', ',');
                        if (res < Convert.ToDouble(num[i]) && Convert.ToDouble(num[i]) % 1 == 0)
                        {
                            res = Convert.ToDouble(num[i]);
                        }
                    }
                }
            }

            return res;
        }
    }
}
