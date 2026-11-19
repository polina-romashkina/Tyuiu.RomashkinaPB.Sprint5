using Tyuiu.RomashkinaPB.Sprint5.Task1.V13.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5,5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
