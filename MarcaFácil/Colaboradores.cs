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
    public partial class Colaboradores : UserControl
    {
        public Colaboradores()
        {
            InitializeComponent();

            PainelColab.Enabled = false;
            btSalvarColab.Hide();
            btCancelarColabEdit.Hide();
            btDeletarColab.Hide();
                   
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            btEditarColab.Hide();
            btNovoColab.Hide();

            btDeletarColab.Show();
            btSalvarColab.Show();
            btCancelarColabEdit.Show(); 

            PainelColab.Enabled = true;
        }

        private void btNovoColab_Click(object sender, EventArgs e)
        {
            btEditarColab.Hide();
            btNovoColab.Hide();

            btDeletarColab.Show();
            btSalvarColab.Show();
            btCancelarColabEdit.Show();
            PainelColab.Enabled = true;

            tab_colaboradoresBindingSource.AddNew();
        }

        private void btCancelarColabEdit_Click(object sender, EventArgs e)
        {
            try
            {
                btEditarColab.Show();
                btNovoColab.Show();

                btDeletarColab.Hide();
                btSalvarColab.Hide();
                btCancelarColabEdit.Hide();

                tab_colaboradoresBindingSource.EndEdit();
                tab_colaboradoresTableAdapter.Fill(bDMARCAFACILDataSet.tab_colaboradores);

                PainelColab.Enabled = false;

                PainelColab.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeleteColab_Click(object sender, EventArgs e)
        {
            try
            { 
                tab_colaboradoresBindingSource.RemoveCurrent();
                tab_colaboradoresBindingSource.EndEdit();
                MessageBox.Show("Dados excluídos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSalvarColab_Click(object sender, EventArgs e)
        {
            try
            {
                btNovoColab.Show();
                btEditarColab.Show();

                btSalvarColab.Hide();
                btCancelarColabEdit.Hide();
                btDeletarColab.Hide();

                PainelColab.Enabled = false;

                tab_colaboradoresBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(bDMARCAFACILDataSet);
                bDMARCAFACILDataSet.tab_agendamento.AcceptChanges();
                bDMARCAFACILDataSet.tab_colaboradores.AcceptChanges();
                bDMARCAFACILDataSet.tab_paciente.AcceptChanges();
                tab_colaboradoresTableAdapter.Fill(bDMARCAFACILDataSet.tab_colaboradores);
                MessageBox.Show("Dados de colaborador salvos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {            
            tab_colaboradoresTableAdapter.Fill(bDMARCAFACILDataSet.tab_colaboradores);    
        }

        private void btProximoColab_Click(object sender, EventArgs e)
        {
            tab_colaboradoresBindingSource.MoveNext();
        }

        private void btAnteriorColab_Click(object sender, EventArgs e)
        {
            tab_colaboradoresBindingSource.MovePrevious();
        }

        private void cargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargoComboBox.Text != "Médico")
            {
                 labelEspecialidade.Hide();
                especialidadeComboBox.Hide();
                cRMTextBox.Hide();
                lblCRM.Hide();
            }
            else if (cargoComboBox.Text == "Médico")
            {
                labelEspecialidade.Show();
                especialidadeComboBox.Show();
                cRMTextBox.Show();
                lblCRM.Show();
            }
        }
    }
}
