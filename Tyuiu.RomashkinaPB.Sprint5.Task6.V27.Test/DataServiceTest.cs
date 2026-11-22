using Tyuiu.RomashkinaPB.Sprint5.Task6.V27.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistedFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V27.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V27.txt");
            int res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
