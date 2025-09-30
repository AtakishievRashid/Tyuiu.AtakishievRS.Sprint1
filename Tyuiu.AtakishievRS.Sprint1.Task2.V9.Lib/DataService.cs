using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AtakishievRS.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return (Math.Round(((r * r * r) * Math.PI * 4.0 / 3.0), 3));
        }
    }
}
