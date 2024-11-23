using Tyuiu.ZhanabaevTA.Sprint5.Task1.V10;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filepath = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(filepath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}