namespace Tyuiu.BabaiKV.Sprint7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCatalog_BKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonAboutUs_BKV_Click(object sender, EventArgs e)
        {
            FormAboutUs_BKV aboutUs = new FormAboutUs_BKV();
            aboutUs.Show();
        }

        private void buttonDetalyZak_BKV_Click(object sender, EventArgs e)
        {
            FormDatalyZak detalyZak = new FormDatalyZak();
            detalyZak.Show();
        }

        private void buttonHelp_BKV_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.Show();
        }

        private void buttonGlavMeny_BKV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
