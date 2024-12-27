using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MaslennikovVA.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = reader.ReadLine().Split(" ");
                foreach (string str in line)
                {
                    if (str.Contains("-")) count++; 
                }
               
            }
            return count;
        }
    }
}
