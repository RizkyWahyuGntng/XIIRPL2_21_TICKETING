using XIIRPL2_21_TICKETING.MasterForm;

namespace XIIRPL2_21_TICKETING
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasterBandara bandara = new FormMasterBandara();
            bandara.Show();
        }
    }
}