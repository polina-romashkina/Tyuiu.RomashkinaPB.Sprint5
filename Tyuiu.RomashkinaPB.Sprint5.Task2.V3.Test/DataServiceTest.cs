using Tyuiu.RomashkinaPB.Sprint5.Task2.V3.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 5, 9, 1 }, { 1, 3, 9 }, { 1, 2, 2 } };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
