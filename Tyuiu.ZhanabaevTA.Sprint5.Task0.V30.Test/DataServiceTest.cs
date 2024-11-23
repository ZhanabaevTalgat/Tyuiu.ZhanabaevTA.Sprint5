using Tyuiu.ZhanabaevTA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filepath = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(filepath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
