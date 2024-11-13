using Tyuiu.GizatullinAP.Sprint3.Task0.V19.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int endValue = 10;
            double res = ds.GetSumSeries(startValue, endValue);
            Assert.AreEqual(4.399, res);
        }
    }
}