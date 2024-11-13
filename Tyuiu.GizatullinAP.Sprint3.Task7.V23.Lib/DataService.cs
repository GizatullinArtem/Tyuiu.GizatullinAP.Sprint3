using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GizatullinAP.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 2;

                
                if (denominator == 0)
                {
                    y = 0; 
                }
                else
                {
                    y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / denominator, 2);
                }

                valueArray[cnt++] = y;
            }

            return valueArray;
        }
    }
}
