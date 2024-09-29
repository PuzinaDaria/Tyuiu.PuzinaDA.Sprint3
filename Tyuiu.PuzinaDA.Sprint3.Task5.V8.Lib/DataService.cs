using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PuzinaDA.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    res = res + (1 / Math.Sin(j) + 3);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
