using Tyuiu.PuzinaDA.Sprint3.Task3.V20.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string value = "gfft ntf f opf";
            char item = 'f';
            int count = ds.GetCharCount(value, item);
            int wait = 5;
            Assert.AreEqual(count, wait);
        }
    }
}