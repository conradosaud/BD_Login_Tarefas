namespace TesteAppRapido01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.TopLevel = false;
            panel1.Controls.Add(login);
            login.Show();
        }
    }
}