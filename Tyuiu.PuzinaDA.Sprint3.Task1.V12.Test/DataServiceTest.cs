using Tyuiu.PuzinaDA.Sprint3.Task1.V12.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int value = 5, startValue = 1, stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.001;
            Assert.AreEqual(res, wait);
        }
    }
}