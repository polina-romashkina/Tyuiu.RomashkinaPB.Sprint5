using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.RomashkinaPB.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] values = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int maxDivBy3 = int.MinValue;
            bool found = false;

            foreach (string value in values)
            {
                double num = double.Parse(value, CultureInfo.InvariantCulture);

                if (num % 1 ==0 && (int) num % 3 ==0)
                {
                    int intNum = (int) num;
                    if(intNum > maxDivBy3)
                    {
                        maxDivBy3 = intNum;
                        found = true;
                    }
                }
            }
            if (!found) return 0;
            double factorial = 1;
            for (int i = 2; i <= maxDivBy3; i++)
            {
                factorial *= i;
            }
            return Math.Round(factorial, 3);
        }
    }
}
