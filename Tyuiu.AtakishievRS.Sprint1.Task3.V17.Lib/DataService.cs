using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AtakishievRS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double fraction1part = number - Math.Truncate(number);
            string fraction1str = fraction1part.ToString("0.0000000").Substring(2);
            return fraction1str.Substring(0, 3).Contains('0');
        }
    }
}
