using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MaslennikovVA.Sprint5.Task4.V26.Lib

{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(".",",");
            double res = Math.Round((Math.Pow(Convert.ToDouble(strX), 3) + Math.Sin(Convert.ToDouble(strX))) * Math.Cos(Convert.ToDouble(strX)), 3);
            return res;
        }
    }
}
