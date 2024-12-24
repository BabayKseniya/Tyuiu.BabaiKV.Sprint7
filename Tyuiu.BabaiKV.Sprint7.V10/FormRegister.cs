using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BabaiKV.Sprint7.V10
{
    public partial class FormRegister : Form
    {
        public FormRegister(string fio, string address, string num, string pay)
        {
            InitializeComponent();
            textBoxResult_BKV.Text = fio;
            textBoxAddress_BKV.Text = address;
            textBoxNumber_BKV.Text = num;
            lblTotalAmount.Text = pay;
            labelTime_BKV.Text = Convert.ToString(DateTime.Now);
        }

        private void buttonOK_BKV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOtziv_BKV_Click(object sender, EventArgs e)
        {
            FormOstavOtziv formOstavOtziv = new FormOstavOtziv();
            formOstavOtziv.Show();
        }
    }
}
