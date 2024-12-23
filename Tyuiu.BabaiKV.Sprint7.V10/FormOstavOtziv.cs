using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.BabaiKV.Sprint7.V10
{
    public partial class FormOstavOtziv : Form
    {
        
        public FormOstavOtziv()
        {
            InitializeComponent();
        }
        static string openfile = @"C:\Users\Пользователь\Desktop\reviews.csv";
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string tovar = textBoxTovar.Text;
            string otziv = textBoxOtziv.Text;
            int rating;
            if (!int.TryParse(textBoxRating.Text, out rating) || rating < 1  || rating > 10)
            {
                MessageBox.Show("Оценка должна быть числом от 1 до 10");
                return;
            }

            // Сохраняем отзыв в CSV
            string newReview = $"{name};{tovar};{otziv};{rating}";
            File.AppendAllText(openfile, newReview + Environment.NewLine);

            MessageBox.Show("Отзыв сохранен!");

            // Закрываем форму
            this.Close();
        }

    }
    
}
