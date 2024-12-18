using Tyuiu.BabaiKV.Sprint7.V10.Lib;
namespace Tyuiu.BabaiKV.Sprint7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService();
            string path = @;
            string[,] wait = new string[,] { {},
                {}, { },
                {}};
            string[,] res = ds.LoadFromData(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}