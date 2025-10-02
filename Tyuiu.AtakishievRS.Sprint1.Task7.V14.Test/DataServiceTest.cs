using Tyuiu.AtakishievRS.Sprint1.Task7.V14.Lib;
namespace Tyuiu.AtakishievRS.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double z = 1.626;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
