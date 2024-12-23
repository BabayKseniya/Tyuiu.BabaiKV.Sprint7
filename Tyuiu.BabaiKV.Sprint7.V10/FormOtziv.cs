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
            foreach (string line in lines)
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
