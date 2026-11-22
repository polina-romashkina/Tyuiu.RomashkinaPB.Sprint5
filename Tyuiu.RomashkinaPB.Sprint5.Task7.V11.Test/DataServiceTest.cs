using Tyuiu.RomashkinaPB.Sprint5.Task7.V11.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistedFile()
        {
            DataService ds = new DataService();
            string inputPath = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V11.txt");
            string outputPath = ds.LoadDataAndSave(inputPath);
            FileInfo fileInfo = new FileInfo(outputPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
