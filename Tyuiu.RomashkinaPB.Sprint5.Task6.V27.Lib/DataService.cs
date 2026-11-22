using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Linq;

namespace Tyuiu.RomashkinaPB.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string part in parts)
                    {
                        if (part.Length == 3 && part.All(char.IsDigit))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
