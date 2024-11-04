namespace SmartConference
{
    public partial class Login_Smart : Form
    {
        public Login_Smart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void StartBt_Click(object sender, EventArgs e)
        {
            if (UserTxtBox.Text == "" || PasswordTxtBox.Text == "")
                MessageBox.Show("Usuario o contraseña Incorrecta");

            if(UserTxtBox.Text == "")
            {
                MessageBox.Show("Usuario Incorrecto");
                UserTxtBox.Focus();
                return;
            }
            if (PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Contraseña Incorrecta");
                UserTxtBox.Focus();
                return;
            }
        }
    }
}
