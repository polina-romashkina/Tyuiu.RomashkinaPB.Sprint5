using Tyuiu.RomashkinaPB.Sprint5.Task3.V25.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            DataService ds = new DataService();
            
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
