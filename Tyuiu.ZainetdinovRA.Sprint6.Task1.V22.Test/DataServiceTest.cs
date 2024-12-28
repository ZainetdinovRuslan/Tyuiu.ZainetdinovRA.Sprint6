using Tyuiu.ZainetdinovRA.Sprint6.Task1.V22.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            double[] expectedRes = { -9.1, 1.55, 292.78, -0.57, -0.35, 2, 4.35, 4.57, -288.78, 2.45, 13.10 };

            for (int i = 0; i < expectedRes.Length; i++)
            {
                Assert.AreEqual(expectedRes[i], result[i]);
            }
        }
    }
}
