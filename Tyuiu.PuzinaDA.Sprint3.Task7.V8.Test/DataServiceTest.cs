using Tyuiu.PuzinaDA.Sprint3.Task7.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] res = new double[11];
            res[0] = -8.86;
            res[1] = -7.19;
            res[2] = -6.14;
            res[3] = -4.76;
            res[4] = -2.33;
            res[5] = 1;
            res[6] = 4.38;
            res[7] = 0;
            res[8] = 6.13;
            res[9] = 7.07;
            res[10] = 8.61;
            double[] wait = new double[11];
            wait = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}