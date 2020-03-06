using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MarcaFácil
{
    public partial class Agendamentos : UserControl
    {
        public Agendamentos()
        {
            InitializeComponent();

            viewAgendamentos.Enabled = false;
            viewAgendamentos.DefaultCellStyle.BackColor = Color.LightGray; 
     
            btSalvar.Hide();
            btCancelar.Hide();
            btDeletar.Hide();        
            GroupBoxdadosDaConsulta.Hide();
        }

        private void viewAgendamentos_SortStringChanged(object sender, EventArgs e)
        {
            tabagendamentoBindingSource.Sort = viewAgendamentos.SortString;
        }

        private void viewAgendamentos_FilterStringChanged(object sender, EventArgs e)
        {
            tabagendamentoBindingSource.Filter = viewAgendamentos.FilterString;
        }

        private void Agendamentos_Load(object sender, EventArgs e)
        {            
            
            tab_agendamentoTableAdapter.Fill(bDMARCAFACILDataSet.tab_agendamento);
            tab_colaboradoresTableAdapter.Fill(bDMARCAFACILDataSet.tab_colaboradores);
            tab_pacienteTableAdapter.Fill(bDMARCAFACILDataSet.tab_paciente);         
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {            
            try
            {            
                btSalvar.Hide();
                btCancelar.Hide();
                btDeletar.Hide();
                GroupBoxdadosDaConsulta.Hide();

                viewAgendamentos.Enabled=false;
                viewAgendamentos.DefaultCellStyle.BackColor = Color.LightGray;

                btEditar.Show();
                btNovo.Show();               

                Validate();                               

                tabagendamentoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(bDMARCAFACILDataSet);
                bDMARCAFACILDataSet.tab_agendamento.AcceptChanges();
                bDMARCAFACILDataSet.tab_colaboradores.AcceptChanges();
                bDMARCAFACILDataSet.tab_paciente.AcceptChanges();
                tab_agendamentoTableAdapter.Fill(bDMARCAFACILDataSet.tab_agendamento);

                MessageBox.Show("Dados de agendamento salvos com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                tabagendamentoBindingSource.RemoveCurrent();                                
                tabagendamentoBindingSource.EndEdit();  

                MessageBox.Show("Dados excluídos");             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                GroupBoxdadosDaConsulta.Hide();
                btDeletar.Hide();
                btSalvar.Hide();
                btCancelar.Hide();
                btNovo.Show();
                btEditar.Show();
        
                tabagendamentoBindingSource.EndEdit();
                tab_agendamentoTableAdapter.Fill(bDMARCAFACILDataSet.tab_agendamento);

                viewAgendamentos.Enabled=false;
                viewAgendamentos.DefaultCellStyle.BackColor = Color.LightGray;

                viewAgendamentos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            btNovo.Hide();
            btEditar.Hide();

            GroupBoxdadosDaConsulta.Show();
            btDeletar.Show();
            btSalvar.Show();
            btCancelar.Show();  

            viewAgendamentos.Enabled=true;
            viewAgendamentos.DefaultCellStyle.BackColor = Color.White;  
        }

        private void btProximoAgend_Click(object sender, EventArgs e)
        {
            tabagendamentoBindingSource.MoveNext();
        }

        private void btAnteriorAgend_Click(object sender, EventArgs e)
        {
           tabagendamentoBindingSource.MovePrevious();
        }       

        private void btNovo_Click(object sender, EventArgs e)
        {
            viewAgendamentos.Enabled = true;
            viewAgendamentos.DefaultCellStyle.BackColor = Color.White;          

            btEditar.Hide();
            btNovo.Hide();
            btDeletar.Show();
            btSalvar.Show();
            btCancelar.Show();
            GroupBoxdadosDaConsulta.Show();
   
        }  
    }
}
