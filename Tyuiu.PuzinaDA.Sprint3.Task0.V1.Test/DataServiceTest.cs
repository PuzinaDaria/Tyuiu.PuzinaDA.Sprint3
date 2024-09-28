using Tyuiu.PuzinaDA.Sprint3.Task0.V1.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int value = 4;
            int startValue = 1, stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1935;
            Assert.AreEqual(res, wait);
        }
    }
}