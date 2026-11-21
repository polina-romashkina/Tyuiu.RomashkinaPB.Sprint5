using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RomashkinaPB.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX.Replace('.', ','));
            double res = Math.Round(((x/(2 * x)) + Math.Sin(Math.Pow(x,2))),3);
            return res;
        }
    }
}
