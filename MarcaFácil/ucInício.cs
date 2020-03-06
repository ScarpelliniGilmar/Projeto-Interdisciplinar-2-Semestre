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
    public partial class ucInício : UserControl
    {
        public ucInício()
        {
            InitializeComponent();
        }

        private void tab_avisosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_avisosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDMARCAFACILDataSet);

        }

        private void ucInício_Load(object sender, EventArgs e)
        {
            tab_avisosTableAdapter.Fill(bDMARCAFACILDataSet.tab_avisos);
        }

        private void btProximoAviso_Click(object sender, EventArgs e)
        {
            tab_avisosBindingSource.MoveNext();
        }

        private void btAnteriorAviso_Click(object sender, EventArgs e)
        {
            tab_avisosBindingSource.MovePrevious();
        }

        private void btSalvarAviso_Click(object sender, EventArgs e)
        {
            try
           {         
               tab_avisosBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(bDMARCAFACILDataSet);
                bDMARCAFACILDataSet.tab_agendamento.AcceptChanges();
                bDMARCAFACILDataSet.tab_colaboradores.AcceptChanges();
                bDMARCAFACILDataSet.tab_paciente.AcceptChanges();
                tab_avisosTableAdapter.Fill(bDMARCAFACILDataSet.tab_avisos);
                MessageBox.Show("Lembretes salvos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
