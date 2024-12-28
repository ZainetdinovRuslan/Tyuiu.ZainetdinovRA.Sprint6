using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = (stopValue - startValue) + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                if (Math.Cos(x) + x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2 * x - 3) / (Math.Cos(x) + x)) + 5;
                    y = Math.Round(y, 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
