using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.RomashkinaPB.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + x) == 0)
                {
                    y = 0;
                }
                else
                {

                    y = Math.Round(((2 * x - 3) / (Math.Cos(x) + x) + 5), 2);
                }
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
                
            }
            return path;
        }
    }
}
