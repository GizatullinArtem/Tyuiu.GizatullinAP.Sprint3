using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GizatullinAP.Sprint3.Task6.V5.Lib
{
    public class DataService : ISprint3Task6V5
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int d = startValue; d <= stopValue; d++)
            {
                int sumOfDivisors = 0;

                for (int i = 1; i <= d; i++)
                {
                    if (d % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }

                totalSum += sumOfDivisors;
            }

            return totalSum;
        }
    }
}
