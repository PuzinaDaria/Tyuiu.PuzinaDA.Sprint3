using Tyuiu.PuzinaDA.Sprint3.Task6.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = 7, stopValue = 16;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 13;
            Assert.AreEqual(res, wait);
        }
    }
}