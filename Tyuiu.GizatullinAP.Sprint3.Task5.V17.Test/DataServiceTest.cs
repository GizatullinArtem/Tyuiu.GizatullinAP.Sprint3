using Tyuiu.GizatullinAP.Sprint3.Task5.V17.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            double wait = 143.624;

            Assert.AreEqual(wait , ds.GetSumSumSeries( x,  startValue1,  startValue2,stopValue1, stopValue2));
        }
    }
}