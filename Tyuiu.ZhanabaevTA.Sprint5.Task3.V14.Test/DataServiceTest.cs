using Tyuiu.ZhanabaevTA.Sprint5.Task3.V14.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint5.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filepath = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(filepath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}