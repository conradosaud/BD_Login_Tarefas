using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAppRapido01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            Usuario usuario = new Usuario();
            usuario = usuario.login(email, senha);

            if( usuario == null )
            {
                MessageBox.Show("Email ou senha incorretos");
                return;
            }

            // Guardar o usuário em outro lugar que não será substituído nunca
            Program.usuario = usuario;

            TelaTarefas telaTarefas = new TelaTarefas();
            telaTarefas.TopLevel = false;
            Form1.panel1.Controls.Clear();
            Form1.panel1.Controls.Add(telaTarefas);
            telaTarefas.Show();

        }
    }
}
