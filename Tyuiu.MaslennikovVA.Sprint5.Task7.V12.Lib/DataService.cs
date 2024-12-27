using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MaslennikovVA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            int count = 0;
            StreamReader reader = new StreamReader(path + @"\InPutDataFileTask7V0.txt");
            string line = reader.ReadLine().ToUpper();
            StreamWriter writer = new StreamWriter(path + @"\OutPutDataFileTask7V0.txt");
            writer.WriteLine(line);
            reader.Close();
            writer.Close();


            return line;
        }
    }
}
