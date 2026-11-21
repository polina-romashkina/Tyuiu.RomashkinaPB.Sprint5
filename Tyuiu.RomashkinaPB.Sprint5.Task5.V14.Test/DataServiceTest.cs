using Tyuiu.RomashkinaPB.Sprint5.Task5.V14.Lib;

namespace Tyuiu.RomashkinaPB.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistedFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V14.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
