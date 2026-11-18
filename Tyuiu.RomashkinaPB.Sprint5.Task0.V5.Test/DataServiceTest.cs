using Tyuiu.RomashkinaPB.Sprint5.Task0.V5.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
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
