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
    public partial class Configurações : UserControl
    {
        public Configurações()
        {
            InitializeComponent();
            btSalvarPermissão.Hide();

        }
        private void btEditarPermissão_Click(object sender, EventArgs e)
        {
            btSalvarPermissão.Show();
            if (painelDesignBtConfig.Visible == false)
            {                
                painelDesignBtConfig.Visible = true;
                painelDesignBtConfig.Height = btEditarPermissão.Height;
                painelDesignBtConfig.Left = btEditarPermissão.Left;
            }
            else
            {
                painelDesignBtConfig.Hide();
            }
            painelPermissões.Enabled = true;
        }

        private void Configurações_Load(object sender, EventArgs e)
        {
            //painelDesignBtConfig.Visible = false; 
            painelDesignBtConfig.Hide();
            painelPermissões.Enabled = false;
            comboBoxUsers.Items.Add(Settings.Default.Usuário.ToString());
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedItem.ToString() == "admin")
            {
                nomeColaboradorLabel1.Text = Settings.Default.Usuário.ToString();
                //Opções de ler
                checkLerAgendamentos.Checked = true;
                checkLerColaboradores.Checked = true;
                checkLerConfigurações.Checked = true;
                checkLerConvênios.Checked = true;
                checkLerInicio.Checked = true;
                checkLerPacientes.Checked = true;
                //Opções de criar
                checkCriarAgendamentos.Checked = true;
                checkCriarColaboradores.Checked = true;
                checkCriarConvênios.Checked = true;
                checkCriarInício.Checked = true;
                checkCriarPacientes.Checked = true;
                //Opções de modificar
                checkModificarAgendamentos.Checked = true;
                checkModificarColab.Checked = true;
                checkModificarConfig.Checked = true;
                checkModificarConvênios.Checked = true;
                checkModificarInício.Checked = true;
                checkModificarPacientes.Checked = true;
                //Opções de deletar
                checkDeletarAgendamentos.Checked = true;
                checkDeletarColab.Checked = true;
                checkDeletarConvênios.Checked = true;
                checkDeletarInício.Checked = true;
                checkDeletarPacientes.Checked = true;
            }
        }

        private void btSalvarPermissão_Click(object sender, EventArgs e)
        {
            try
            {
                btSalvarPermissão.Hide();
                painelDesignBtConfig.Hide();
                painelPermissões.Update();
                painelPermissões.Enabled = false;
                MessageBox.Show("Alterações salvas com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelarColabEdit_Click(object sender, EventArgs e)
        {
            btSalvarPermissão.Hide();
            painelDesignBtConfig.Hide();
           painelPermissões.Enabled = false;                                                                            
        }
    }
}
