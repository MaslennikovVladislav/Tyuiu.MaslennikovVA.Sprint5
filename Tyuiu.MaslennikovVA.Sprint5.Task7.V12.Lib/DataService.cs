using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MaslennikovVA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {

            StreamReader reader = new StreamReader(path + @"\InPutDataFileTask7V0.txt");
            string line = reader.ReadLine().ToUpper();
            FileInfo fileInfo = new FileInfo(path + @"\OutPutDataFileTask7V0.txt");
            //if (!fileInfo.Exists)
            //    File.Create(path + @"\OutPutFileTask7V0.txt");

            StreamWriter writer = new StreamWriter(path + @"\OutPutDataFileTask7V0.txt");
            writer.WriteLine(line);
            reader.Close();
            writer.Close();


            return line;
        }
    }
}
