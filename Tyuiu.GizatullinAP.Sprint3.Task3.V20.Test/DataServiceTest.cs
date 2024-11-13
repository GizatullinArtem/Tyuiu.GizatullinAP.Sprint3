using Tyuiu.GizatullinAP.Sprint3.Task3.V20.Lib;

namespace Tyuiu.GizatullinAP.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var wait = 5;
            Assert.AreEqual(wait, ds.GetCharCount("gfft ntf f opf", 'f'));
        }
    }
}