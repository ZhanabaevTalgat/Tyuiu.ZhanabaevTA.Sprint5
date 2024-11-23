namespace Tyuiu.ZhanabaevTA.Sprint5.Task2.V8.Test
{
    [TestClass]
    public class DataSerrviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filepath = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(filepath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}