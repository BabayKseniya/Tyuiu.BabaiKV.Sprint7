using System.Drawing;


namespace Tyuiu.BabaiKV.Sprint7.V10.Lib
{
    public  class DataService
    {
        public string[,] LoadFromData(string path)
        {

            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }
            return array;
        }
        

    }
    
    public static class CsvHelper
    {
        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; } // Путь к изображению товара
        }

        public class CartItem
        {
            public int ProductID { get; set; }
            public int Quantity { get; set; }
        }
        
        // Чтение товаров из CSV
        public static List<Product> ReadProducts(string filePath)
        {
            var products = new List<Product>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines.Skip(1)) // Пропускаем заголовок
                {
                    var fields = line.Split(';');
                    var product = new Product
                    {
                        ID = int.Parse(fields[0]),
                        Name = fields[1],
                        Price = decimal.Parse(fields[2]),
                        ImagePath = fields[3]
                    };
                    products.Add(product);
                }
            }
            return products;
        }

        // Чтение корзины из CSV
        public static List<CartItem> ReadCart(string filePath)
        {
            var cart = new List<CartItem>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines.Skip(1)) // Пропускаем заголовок
                {
                    var fields = line.Split(';');
                    var cartItem = new CartItem
                    {
                        ProductID = int.Parse(fields[0]),
                        Quantity = int.Parse(fields[1])
                    };
                    cart.Add(cartItem);
                }
            }
            return cart;
        }

        // Запись корзины в CSV
        public static void WriteCart(string filePath, List<CartItem> cart)
        {
            var lines = new List<string> { "ProductID;Quantity" };
            foreach (var item in cart)
            {
                lines.Add($"{item.ProductID};{item.Quantity}");
            }
            File.WriteAllLines(filePath, lines);
        }

        

        // Обновление количества товара в корзине
        public static void UpdateQuantity(int productID, int quantity, string cartFilePath)
        {
            var cart = ReadCart(cartFilePath);
            var cartItem = cart.FirstOrDefault(c => c.ProductID == productID);

            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
            }

            WriteCart(cartFilePath, cart);
        }

        // Удаление товара из корзины
        public static void RemoveFromCart(int productID, string cartFilePath)
        {
            var cart = ReadCart(cartFilePath);
            var cartItem = cart.FirstOrDefault(c => c.ProductID == productID);

            if (cartItem != null)
            {
                cart.Remove(cartItem);
            }

            WriteCart(cartFilePath, cart);
        }
        public class Cart
        {
            private List<Product> products = new List<Product>();

            // Метод для добавления товара в корзину
            public void AddProduct(Product product)
            {
                products.Add(product);
            }

            // Метод для получения списка товаров в корзине
            public List<Product> GetProducts()
            {
                return products;
            }

            // Метод для вычисления общей стоимости товаров в корзине
            public decimal GetTotal()
            {
                return products.Sum(p => p.Price);
            }
        }
    }
}
