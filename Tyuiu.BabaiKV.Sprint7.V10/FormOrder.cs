using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BabaiKV.Sprint7.V10.Lib;

namespace Tyuiu.BabaiKV.Sprint7.V10
{
    public partial class FormOrder : Form
    {
        DataService ds = new DataService();
        public string fio;
        public string address;
        public string pay;
        public string totalSum;
        public string num;
        public string name;
        public string surname;
        public string midname;
        public string productsOrder;
        private decimal totalAmount;
        public FormOrder(decimal total)
        {
            InitializeComponent();
            totalAmount = total;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // Отображаем сумму заказа на форме
            lblTotalAmount.Text = $"Сумма заказа: {totalAmount:F2}";
        }

        private void buttonRegister_BKV_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)(DateTime.Now.Ticks));
            

            if ((textBoxName_BKV.Text != "") && (textBoxSurname_BKV.Text != "") &&
                (textBoxAddress_BKV.Text != "") && (textBoxMidname_BKV.Text != "") &&
                (radioButtonPaypoluch_BKV.Text != "" || radioButtonPayonl_BKV.Text != ""))
            {
                name = textBoxName_BKV.Text;
                surname = textBoxSurname_BKV.Text;
                midname = textBoxMidname_BKV.Text;

                fio = surname + "\t" + name + "\t" + midname;
                address = textBoxAddress_BKV.Text;
                if (radioButtonPaypoluch_BKV.Checked == true)
                {
                    pay = radioButtonPaypoluch_BKV.Text;
                }
                else
                {
                    pay = radioButtonPayonl_BKV.Text;
                }
                num = Convert.ToString(rand.Next(1000, 10000));

                FormRegister register = new FormRegister(fio, address, num, pay);
                register.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] inforegister = new string[] { surname, name, midname, address, num, pay };
            saveFileDialog_BKV.FileName = "Информация о заказах.csv";
            saveFileDialog_BKV.InitialDirectory = @"C:\Users\Пользователь\Documents";
            saveFileDialog_BKV.ShowDialog();

            string path = saveFileDialog_BKV.FileName;

            int columns = 6;
            string str = "";


            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    str += inforegister[j] + ";";
                }
                else
                {
                    str += inforegister[j];
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";


            saveFileDialog_BKV.FileName = "Заказы.csv";
            saveFileDialog_BKV.InitialDirectory = @"C:\Users\Пользователь\Documents";
            saveFileDialog_BKV.ShowDialog();

            string pathorders = saveFileDialog_BKV.FileName;
            int column = 3;
            string strOrder = "";
            string[] orders = new string[] { num, totalSum, productsOrder };
            for (int c = 0; c < column; c++)
            {
                if (c != column - 1)
                {
                    strOrder += orders[c] + ";";
                }
                else
                {
                    strOrder += orders[c];
                }
            }
            File.AppendAllText(pathorders, strOrder + Environment.NewLine);
            str = "";
        }
    }
}
