﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GizatullinAP.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries( int startValue, int stopValue)
        {
            double SumSeries = 0;

            do
            {
                SumSeries = SumSeries + (Math.Pow((1 / ((Math.Cos(startValue)) + 2)), 2));
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(SumSeries, 3);
        }

       
        
           
    }
}