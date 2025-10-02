using Tyuiu.AtakishievRS.Sprint1.Task6.V18.Lib;
namespace Tyuiu.AtakishievRS.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "122";
            Assert.AreEqual(true, ds.CheckNumber(a));
        }
    }
}
