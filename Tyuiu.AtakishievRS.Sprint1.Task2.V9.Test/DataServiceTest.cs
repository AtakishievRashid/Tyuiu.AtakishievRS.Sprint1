using Tyuiu.AtakishievRS.Sprint1.Task2.V9.Lib;
namespace Tyuiu.AtakishievRS.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(8, res);
        }
    }
}
