using tyuiu.cources.programming.interfaces.Sprint3; 
namespace Tyuiu.PuzinaDA.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;
            for(int i = startValue; i <= stopValue; i++)
            {
                if (2 - i == 0)
                {
                    res[count] = 0; 
                    count++;
                }
                else
                {
                    res[count] = Math.Round((Math.Sin(i) + ((Math.Cos(i) + 1) / (2 - i)) + 2 * i), 2);
                    count++;
                }
            }
            return res;
        }
    }
}
