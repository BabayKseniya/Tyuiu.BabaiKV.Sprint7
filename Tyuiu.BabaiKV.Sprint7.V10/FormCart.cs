using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tyuiu.BabaiKV.Sprint7.V10.Lib.CsvHelper;



namespace Tyuiu.BabaiKV.Sprint7.V10
{

    public partial class FormCart : Form
    {

        public FormCart()
        {
            InitializeComponent();
            InitializeDataGridView();  // Инициализация DataGridView
        }
        private void InitializeDataGridView()
        {
            // Удаляем все старые столбцы (если они есть) перед добавлением новых
            dataGridViewCart.Columns.Clear();

            // Настроим столбцы в DataGridView
            dataGridViewCart.Columns.Add("ProductNameColumn", "Название товара");
            dataGridViewCart.Columns.Add("ProductPriceColumn", "Цена");

            // Можно задать ширину столбцов
            dataGridViewCart.Columns["ProductNameColumn"].Width = 250;
            dataGridViewCart.Columns["ProductPriceColumn"].Width = 100;
        }

        // Метод для загрузки данных из CSV файла в DataGridView
        private void LoadCartData()
        {
            string filePath = "cart.csv";  // Путь к файлу корзины

            // Проверка, существует ли файл
            if (File.Exists(filePath))
            {
                // Чтение всех строк из CSV
                var lines = File.ReadAllLines(filePath);

                // Проверка, что строки файла не пустые
                if (lines.Length > 1) // Если в файле есть данные (кроме заголовка)
                {
                    foreach (var line in lines.Skip(1))  // Пропускаем заголовок
                    {
                        // Разделяем строку на части по запятой
                        var columns = line.Split(',');

                        // Проверка, что разделение прошло корректно
                        if (columns.Length == 2)
                        {
                            string productName = columns[0].Trim('"');  // Убираем кавычки, если они есть
                            decimal productPrice = decimal.Parse(columns[1].Trim('"'));  // Преобразуем цену в decimal

                            // Логируем данные, чтобы убедиться, что они корректно разделены
                            MessageBox.Show($"Добавление товара: {productName}, {productPrice}");

                            // Добавляем данные в DataGridView
                            dataGridViewCart.Rows.Add(productName, productPrice);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка при разборе строки: {line}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл пуст или содержит только заголовки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл корзины не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Событие, которое вызывается при загрузке формы
        private void FormCart_Load(object sender, EventArgs e)
        {
            // Загружаем данные из CSV в DataGridView

        }

        private void FormCart_Load_1(object sender, EventArgs e)
        {
            // Загружаем данные из CSV в DataGridView
            LoadCartData();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            // Перебираем строки в DataGridView
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells["ProductPriceColumn"].Value != null)
                {
                    // Преобразуем строковое значение в decimal
                    if (decimal.TryParse(row.Cells["ProductPriceColumn"].Value.ToString(), out decimal productPrice))
                    {
                        total += productPrice;  // Добавляем к общей сумме
                    }
                }
            }

            // Выводим результат в текстовое поле
            txtResult.Text = total.ToString();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Получаем итоговую сумму из txtResult
            if (decimal.TryParse(txtResult.Text, out decimal totalAmount))
            {
                // Создаем форму для оформления заказа и передаем сумму
                FormOrder orderForm = new FormOrder(totalAmount);
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка в расчете суммы. Пожалуйста, проверьте итог.");
            }
        }
    }
}
