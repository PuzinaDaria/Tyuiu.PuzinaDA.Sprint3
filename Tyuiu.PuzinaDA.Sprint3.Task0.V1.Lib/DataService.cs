﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PuzinaDA.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res = res + ((Math.Pow(value, 2) * i) + 1);   
            }
            return res;
        }
    }
}
