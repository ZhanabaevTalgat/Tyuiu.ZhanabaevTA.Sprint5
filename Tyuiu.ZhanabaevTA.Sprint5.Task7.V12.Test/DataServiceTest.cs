namespace Tyuiu.ZhanabaevTA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutDataFileTask7V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}