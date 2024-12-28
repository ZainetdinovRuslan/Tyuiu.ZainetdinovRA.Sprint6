using Tyuiu.ZainetdinovRA.Sprint6.Task0.V5.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(5);
            double expectedRes = -114.5;
            Assert.AreEqual(expectedRes, result);
        }
    }
}
