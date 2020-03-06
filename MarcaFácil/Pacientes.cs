using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcaFácil
{
    public partial class Pacientes : UserControl
    {
        public Pacientes()
        {
            InitializeComponent();

            painelCadastroPaciente.Enabled = false;
            btSalvarPaciente.Hide();
            btCancelarPacienteEdit.Hide();
            btDeletarPaciente.Hide();
        } 

        private void Pacientes_Load(object sender, EventArgs e)
        {
            tab_pacienteTableAdapter.Fill(bDMARCAFACILDataSet.tab_paciente);
        }

        private void btProximoColab_Click(object sender, EventArgs e)
        {
            tab_pacienteBindingSource.MoveNext();
        }

        private void btAnteriorColab_Click(object sender, EventArgs e)
        {
            tab_pacienteBindingSource.MovePrevious();
        }

        private void btSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                btNovoPaciente.Show();
                btEditarPaciente.Show();

                btSalvarPaciente.Hide();
                btDeletarPaciente.Hide();
                btCancelarPacienteEdit.Hide();

                painelCadastroPaciente.Enabled = false;

                Validate();

                tab_pacienteBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(bDMARCAFACILDataSet);
                bDMARCAFACILDataSet.tab_agendamento.AcceptChanges();
                bDMARCAFACILDataSet.tab_colaboradores.AcceptChanges();
                bDMARCAFACILDataSet.tab_paciente.AcceptChanges();
                tab_pacienteTableAdapter.Fill(bDMARCAFACILDataSet.tab_paciente);
                MessageBox.Show("Dados de paciente salvos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeletarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                tab_pacienteBindingSource.RemoveCurrent();
                tab_pacienteBindingSource.EndEdit();
                MessageBox.Show("Dados excluídos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelarPacienteEdit_Click(object sender, EventArgs e)
        {
            try
            {
                btNovoPaciente.Show();
                btEditarPaciente.Show();

                btDeletarPaciente.Hide();
                btSalvarPaciente.Hide();
                btCancelarPacienteEdit.Hide();

                tab_pacienteBindingSource.EndEdit();
                tab_pacienteTableAdapter.Fill(bDMARCAFACILDataSet.tab_paciente);

                painelCadastroPaciente.Enabled = false;

                painelCadastroPaciente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNovoPaciente_Click(object sender, EventArgs e)
        {
            btDeletarPaciente.Show();
            btSalvarPaciente.Show();
            btCancelarPacienteEdit.Show();

            btEditarPaciente.Hide();
            btNovoPaciente.Hide();

            painelCadastroPaciente.Enabled = true;

            tab_pacienteBindingSource.AddNew();
        }

        private void btEditarPaciente_Click(object sender, EventArgs e)
        {
            btNovoPaciente.Hide();
            btEditarPaciente.Hide();

            btDeletarPaciente.Show();
            btSalvarPaciente.Show();
            btCancelarPacienteEdit.Show();

            painelCadastroPaciente.Enabled = true;
        }
    }
}
