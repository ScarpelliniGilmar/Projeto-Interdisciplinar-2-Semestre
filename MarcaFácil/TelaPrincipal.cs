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
using System.Drawing.Drawing2D;

namespace MarcaFácil
{
    public partial class TelaPrincipal : Form
    {      
        //Define evento de mouseDrag como falso
        private bool _mouseDrag = false;
        //Define ponto de início
        private Point _start_point = new Point(0, 0);

        public TelaPrincipal()
        {
            InitializeComponent();
            //Propriedades para definição de valores em label e picture no perfil do administrador
            if (Settings.Default.Usuário.ToString() == "admin")
            {
                lblUserName.Text = "Admin";
                UserPicture.Image = Resources.Admin;
            }
        }
        //Variáveis de captura do ponteiro do mouse 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        //Importação de dll's do sistema
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //Realiza captura dos pontos do mouse
        public static extern bool ReleaseCapture();
        //Propriedades do evento MouseDown, realiza captura do ponteiro         
        private void TelaPrincipal_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //Propriedades do evento MouseMove, torna possível a localização do ponteiro
        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDrag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDrag = false;
        }

        //Propriedades do botão fechar, traz opções caso o usuário deseja realmente sair ou não
        private void btFechar_Click(object sender, EventArgs e)
        {
            var message = "Tem certeza que deseja sair?";
            var title = "";
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

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btInício_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btInício.Height;
            pBtLateral.Top = btInício.Top;

            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                ucInício ucInício = new ucInício();
                painelPrincipal.Controls.Add(ucInício);
            }
        }

        private void btPacientes_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btPacientes.Height;
            pBtLateral.Top = btPacientes.Top;
            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                Pacientes pacientes = new Pacientes();
                painelPrincipal.Controls.Add(pacientes);
            }
        }

        private void btAgendamentos_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btAgendamentos.Height;
            pBtLateral.Top = btAgendamentos.Top;
            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                Agendamentos agendamentos = new Agendamentos();
                painelPrincipal.Controls.Add(agendamentos);
            }
        }

        private void btColaboradores_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btColaboradores.Height;
            pBtLateral.Top = btColaboradores.Top;
            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                Colaboradores colaboradores = new Colaboradores();
                painelPrincipal.Controls.Add(colaboradores);
            }
        }       

        private void btAjuda_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btAjuda.Height;
            pBtLateral.Top = btAjuda.Top;
            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                Ajuda ajuda = new Ajuda();
                painelPrincipal.Controls.Add(ajuda);
            }
        }

        private void btConfigurações_Click(object sender, EventArgs e)
        {
            pBtLateral.Height = btConfigurações.Height;
            pBtLateral.Top = btConfigurações.Top;
            if (painelPrincipal != null)
            {
                while (painelPrincipal.Controls.Count > 0)
                {
                    painelPrincipal.Controls[0].Dispose();
                }
                Configurações configurações = new Configurações();
                painelPrincipal.Controls.Add(configurações);
            }
        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToShortTimeString();
        }
    }    
}

