using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MaslennikovVA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            int min = 99;
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int max;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.Contains(",") && !line.Contains("."))
                    {
                        max = Convert.ToInt32(line);
                        if (max % 100 == max && max % 10 != max)
                        {
                            if (max < min)
                                min = max;
                        }
                            
                    }
                }
                                                                    //res = res + Convert.ToDouble(line);
            }
            return min;
        }
    }
}
