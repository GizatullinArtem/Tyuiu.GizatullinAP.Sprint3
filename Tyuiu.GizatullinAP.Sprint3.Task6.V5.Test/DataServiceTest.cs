using Tyuiu.GizatullinAP.Sprint3.Task6.V5.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;
            int wait = 33;


            Assert.AreEqual(wait, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}