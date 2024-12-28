using Tyuiu.ZainetdinovRA.Sprint6.Task2.V22.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            double[] expectedRes = { 7.76, 7.36, 7.26, 7.9, 15.88, 2, 4.35, 5.63, 6.49, 6.49, 6.32 };

            for (int i = 0; i < expectedRes.Length; i++)
            {
                Assert.AreEqual(expectedRes[i], result[i]);
            }
        }
    }
}
