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
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.BabaiKV.Sprint7.V10
{
    public partial class FormOtziv : Form
    {

        public FormOtziv()
        {
            InitializeComponent();
            LoadReviews();

        }
        static string openfile = @"C:\Users\Пользователь\Desktop\reviews.csv";
        public class Review
        {
            public string Name { get; set; }
            public string Tovar { get; set; }
            public string Otziv { get; set; }
            public int Rating { get; set; }

            public Review(string name, string tovar, string otziv, int rating)
            {
                Name = name;
                Tovar = tovar;
                Otziv = otziv;
                Rating = rating;
            }

        }

        private void LoadReviews()
        {
            // Загрузка данных из CSV в DataGridView
            string[] lines = File.ReadAllLines(openfile);
            List<Review> reviews = new List<Review>();
            //bool isFirstLine = true;  // Флаг для пропуска первой строки
            foreach (string line in lines)
            {
                //if (isFirstLine)
                //{
                //  isFirstLine = false;  // Первая строка пропущена
                //continue;  // Переходим к следующей строке
                //}
                var columns = line.Split(';');
                if (columns.Length == 4)
                {
                    reviews.Add(new Review(columns[0], columns[1], columns[2], int.Parse(columns[3])));
                }
            }
            dataGridViewOtziv_BKV.DataSource = reviews;
        }

        private void buttonOstavOtziv_BKV_Click(object sender, EventArgs e)
        {
            FormOstavOtziv formOstavOtziv = new FormOstavOtziv();
            formOstavOtziv.Show();
        }

        private void buttonOK_BKV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChartAddLine_BKV_Click(object sender, EventArgs e) //создание графа
        {
            BuildChartByRating("review.csv");  // Строим график по оценкам
        }
        // Метод для построения графика по столбцу "Оценка"
        private void BuildChartByRating(string filePath)
        {
            var ratingsCount = new Dictionary<int, int>();  // Для подсчета количества каждой оценки

            // Чтение файла и обработка данных
            var lines = File.ReadLines(filePath).Skip(1);  // Пропускаем первую строку (заголовки)

            foreach (var line in lines)
            {
                var columns = line.Split(';');

                if (columns.Length == 4)
                {
                    // Преобразуем строку в целое число для "Оценка" (столбец 3)
                    if (int.TryParse(columns[3], out int rating))
                    {
                        if (ratingsCount.ContainsKey(rating))
                        {
                            ratingsCount[rating]++;
                        }
                        else
                        {
                            ratingsCount[rating] = 1;
                        }
                    }
                }
            }

            // Очищаем Chart перед добавлением новых данных
            chartProduct.Series.Clear();
            chartProduct.Legends.Clear();

            // Добавляем серию для графика
            var series = new Series("Оценки")
            {
                ChartType = SeriesChartType.Spline  // Столбчатая диаграмма
            };

            // Добавляем данные для серии
            foreach (var rating in ratingsCount)
            {
                series.Points.AddXY(rating.Key, rating.Value);
            }

            // Добавляем серию в Chart
            chartProduct.Series.Add(series);
        }

        private void buttonOK_BKV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

