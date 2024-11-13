using Tyuiu.GizatullinAP.Sprint3.Task7.V23.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1 ;
            double[] valueWaitArray = 
            {
                13.80,
                11.86, 
                9.87,  
                7.73,   
                5.36,   
                2.50,   
                0.00,   
                0.79,   
                -1.74,  
                -3.77,  
                -5.71   
            };
            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(res, valueWaitArray);

        }
    }
}