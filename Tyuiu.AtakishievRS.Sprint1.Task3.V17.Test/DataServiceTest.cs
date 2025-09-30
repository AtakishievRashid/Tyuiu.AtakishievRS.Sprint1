using Microsoft.CodeCoverage.Core;
using Tyuiu.AtakishievRS.Sprint1.Task3.V17.Lib;
namespace Tyuiu.AtakishievRS.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ZeroCheck()
        {
            DataService ds = new DataService();
            double number = 12.038;

            bool result = ds.ZeroCheck(number);

            Assert.IsTrue(result);

        }
    }
}
