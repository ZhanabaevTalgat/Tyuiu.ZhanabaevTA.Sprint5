using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task6.V2.Lib
{
    public class DataService : ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            string rus = "ёйцукенгшщзхъфывапролджэячсмитьбю";
            string line;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToLower();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (rus.Contains(line[i]))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
