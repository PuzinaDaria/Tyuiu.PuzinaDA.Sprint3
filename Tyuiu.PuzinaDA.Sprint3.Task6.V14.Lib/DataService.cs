using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PuzinaDA.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        if (y>5)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
