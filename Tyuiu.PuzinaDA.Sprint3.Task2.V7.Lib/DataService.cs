using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PuzinaDA.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res = res + Math.Pow((1 / Math.Sin(startValue)), 2);
                startValue += 1;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
