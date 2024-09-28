using Tyuiu.PuzinaDA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = 1, stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 81.083;
            Assert.AreEqual(res, wait);
        }
    }
}