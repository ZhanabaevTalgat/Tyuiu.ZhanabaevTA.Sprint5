using Tyuiu.ZhanabaevTA.Sprint5.Task6.V2.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}