using Tyuiu.AtakishievRS.Sprint1.Task5.V5.Lib;
namespace Tyuiu.AtakishievRS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            var d = ds.Calculate(x);
            Assert.AreEqual(5, d);
        }
    }
}
