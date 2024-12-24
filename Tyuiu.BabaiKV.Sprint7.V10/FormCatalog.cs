using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BabaiKV.Sprint7.V10.Lib;


namespace Tyuiu.BabaiKV.Sprint7.V10
{


    public partial class FormCatalog : Form
    {



        public FormCatalog()
        {
            InitializeComponent();


        }
        public void AddToCart(string productName, decimal productPrice)
        {
            string filePath = "cart.csv";  // Путь к файлу CSV

            // Проверяем, существует ли файл, если нет - создаем его
            if (!File.Exists(filePath))
            {
                // Создаем файл и записываем заголовок
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Название,Цена");
                }
            }

            // Добавляем данные о товаре в файл
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"\"{productName}\",\"{productPrice}\"");
            }
        }

        private void btnAddToCart1_Click(object sender, EventArgs e)
        {
            string productName = txtProductName1.Text;
            decimal productPrice = decimal.Parse(txtProductPrice1.Text);  // Преобразуем строку в число
            AddToCart(productName, productPrice);  // Добавляем товар в корзину
        }

        private void btnAddToCart2_Click(object sender, EventArgs e)
        {
            string productName = txtProductName2.Text;
            decimal productPrice = decimal.Parse(txtProductPrice2.Text);
            AddToCart(productName, productPrice);
        }

        private void btnAddToCart3_Click(object sender, EventArgs e)
        {
            string productName = txtProductName3.Text;
            decimal productPrice = decimal.Parse(txtProductPrice3.Text);
            AddToCart(productName, productPrice);
        }

        private void btnAddToCart4_Click(object sender, EventArgs e)
        {
            string productName = txtProductName4.Text;
            decimal productPrice = decimal.Parse(txtProductPrice4.Text);
            AddToCart(productName, productPrice);
        }

        private void btnAddToCart5_Click(object sender, EventArgs e)
        {
            string productName = txtProductName5.Text;
            decimal productPrice = decimal.Parse(txtProductPrice5.Text);
            AddToCart(productName, productPrice);
        }

        private void btnAddToCart6_Click(object sender, EventArgs e)
        {
            string productName = txtProductName6.Text;
            decimal productPrice = decimal.Parse(txtProductPrice6.Text);
            AddToCart(productName, productPrice);
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            // Здесь откроем форму корзины
            var cartForm = new FormCart();
            cartForm.Show();
        }
    }
}

