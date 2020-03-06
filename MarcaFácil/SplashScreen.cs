using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcaFácil
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            barraDeCarregamento.Increment(3);
            if (barraDeCarregamento.Value == 100)
            {
                timerLoading.Stop();
                Close();
                TelaPrincipal marcaFácil = new TelaPrincipal();
                marcaFácil.Show();
            }

        }

        private void timerTexto_Tick(object sender, EventArgs e)
        {
            List<string> randomText = new List<string>();
            randomText.Add("Atualizando agendas...");
            randomText.Add("Preparando consultas...");
            randomText.Add("Colaborando com os colaboradores...");
            randomText.Add("Checando horários...");
            randomText.Add("Agendando consultas...");
            randomText.Add("Carregando cadastros...");
            int i = DateTime.Now.Second % randomText.Count;
            lblTextoAleatório.Text = randomText[i];
        }
    }
}
