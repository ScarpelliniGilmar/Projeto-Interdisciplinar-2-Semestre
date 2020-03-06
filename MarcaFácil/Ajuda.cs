using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcaFácil.Properties;

namespace MarcaFácil
{
    public partial class Ajuda : UserControl
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void listAbasAjuda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAbasAjuda.Text == "Início")
            {
                pictureAbasHelper.Image = Resources.InícioHelp;
            }
            else if (listAbasAjuda.Text == "Aba Agendamentos")
            {
                pictureAbasHelper.Image = Resources.AgendaROHelp;
            }
            else if (listAbasAjuda.Text == "Criando agendamento")
            {
                pictureAbasHelper.Image = Resources.AgendaHelp;
            }
            else if (listAbasAjuda.Text == "Aba Paciente")
            {
                pictureAbasHelper.Image = Resources.PacienteROHelp;
            }
            else if (listAbasAjuda.Text == "Adicionando paciente")
            {
                pictureAbasHelper.Image = Resources.PacienteHelp;
            }
            else if (listAbasAjuda.Text=="Aba Colaboradores")
            {
                pictureAbasHelper.Image = Resources.ColabROHelp;
            }           
            else if (listAbasAjuda.Text=="Adicionando colaborador")
            {
                pictureAbasHelper.Image = Resources.ColabHelp;
            }
            else if(listAbasAjuda.Text=="Aba Configurações")
            {
                pictureAbasHelper.Image = Resources.ConfigROHelp;
            }
            else if(listAbasAjuda.Text=="Alterando configurações")
            {
                pictureAbasHelper.Image = Resources.ConfigHelp;
            }

        }
    }
}
