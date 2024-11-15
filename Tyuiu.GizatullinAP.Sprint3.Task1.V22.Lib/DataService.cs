﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GizatullinAP.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value,startValue) + (1.00/2.00)) * Math.Cos(startValue);
                startValue += 1;
            }
            return Math.Round(sumSeries, 3);
        }

    }
}