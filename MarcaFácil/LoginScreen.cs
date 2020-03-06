using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcaFácil.Properties;

namespace MarcaFácil
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            txtUsuário.Focus();
        }
        private void btAcessar_Click(object sender, EventArgs e)
        {
            string UserName = Settings.Default.Usuário;
            string Password = Settings.Default.Senha;

            if (txtUsuário.Text == UserName && txtSenha.Text == Password)
            {
                Hide();
                SplashScreen splashScreen = new SplashScreen();
                splashScreen.Show();
            }
            else if (txtUsuário.Text != UserName || txtSenha.Text != Password)
            {
                MessageBox.Show("Usuário ou senha inválido(s)");
            }
        }

        private void btSairPrograma_Click(object sender, EventArgs e)
        {
            var message = "Tem certeza que deseja sair?";
            var title = "MarcaFácil";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    Close();
                    Application.Exit();
                    break;
                case DialogResult.No:
                    DialogResult = DialogResult.No;
                    break;
            }
        }
    }
}
