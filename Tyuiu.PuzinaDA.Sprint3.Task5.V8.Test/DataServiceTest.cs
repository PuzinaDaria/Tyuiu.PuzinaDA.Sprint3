using Tyuiu.PuzinaDA.Sprint3.Task5.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 12;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            double wait = 119.066;
            Assert.AreEqual(res, wait);
        }
    }
}