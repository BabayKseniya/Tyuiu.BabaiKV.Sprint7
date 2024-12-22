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
            string path = @"C:\Users\Пользователь\Desktop\IGaame.csv";
            string[,] wait = new string[,] { {"№","Артикул","Товар","Стоимость","Оценка"},
                {"1","1234","Компьютер","100000","8" }, { "2","1235","Мышь","1000","7"}};
            string[,] res = ds.LoadFromData(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}