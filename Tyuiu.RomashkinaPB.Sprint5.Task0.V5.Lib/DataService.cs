using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RomashkinaPB.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Log((double)(x + 1) / (x + 2));
            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}
