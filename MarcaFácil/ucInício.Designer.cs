namespace MarcaFácil
{
    partial class ucInício
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bDMARCAFACILDataSet = new MarcaFácil.BDMARCAFACILDataSet();
            this.tab_avisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_avisosTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_avisosTableAdapter();
            this.tableAdapterManager = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avisosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLabel1 = new System.Windows.Forms.Label();
            this.btProximoAviso = new System.Windows.Forms.Button();
            this.btAnteriorAviso = new System.Windows.Forms.Button();
            this.lblQuadroDeAvisos = new System.Windows.Forms.Label();
            this.dataMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btSalvarAviso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_avisosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDMARCAFACILDataSet
            // 
            this.bDMARCAFACILDataSet.DataSetName = "BDMARCAFACILDataSet";
            this.bDMARCAFACILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_avisosBindingSource
            // 
            this.tab_avisosBindingSource.DataMember = "tab_avisos";
            this.tab_avisosBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // tab_avisosTableAdapter
            // 
            this.tab_avisosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tab_agendamentoTableAdapter = null;
            this.tableAdapterManager.tab_avisosTableAdapter = this.tab_avisosTableAdapter;
            this.tableAdapterManager.tab_colaboradoresTableAdapter = null;
            this.tableAdapterManager.tab_pacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // advancedDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.advancedDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDataGridViewTextBoxColumn,
            this.avisosDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.tab_avisosBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 239);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowTemplate.Height = 30;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1028, 414);
            this.advancedDataGridView1.TabIndex = 3;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            this.códigoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.códigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // avisosDataGridViewTextBoxColumn
            // 
            this.avisosDataGridViewTextBoxColumn.DataPropertyName = "Avisos";
            this.avisosDataGridViewTextBoxColumn.HeaderText = "Avisos";
            this.avisosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.avisosDataGridViewTextBoxColumn.Name = "avisosDataGridViewTextBoxColumn";
            this.avisosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.avisosDataGridViewTextBoxColumn.Width = 865;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataLabel1
            // 
            this.dataLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_avisosBindingSource, "Data", true));
            this.dataLabel1.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel1.ForeColor = System.Drawing.Color.White;
            this.dataLabel1.Location = new System.Drawing.Point(57, 140);
            this.dataLabel1.Name = "dataLabel1";
            this.dataLabel1.Size = new System.Drawing.Size(152, 45);
            this.dataLabel1.TabIndex = 4;
            this.dataLabel1.Text = "label1";
            // 
            // btProximoAviso
            // 
            this.btProximoAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btProximoAviso.FlatAppearance.BorderSize = 0;
            this.btProximoAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximoAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoAviso.ForeColor = System.Drawing.Color.White;
            this.btProximoAviso.Location = new System.Drawing.Point(215, 145);
            this.btProximoAviso.Name = "btProximoAviso";
            this.btProximoAviso.Size = new System.Drawing.Size(38, 35);
            this.btProximoAviso.TabIndex = 75;
            this.btProximoAviso.Text = ">";
            this.btProximoAviso.UseVisualStyleBackColor = false;
            this.btProximoAviso.Click += new System.EventHandler(this.btProximoAviso_Click);
            // 
            // btAnteriorAviso
            // 
            this.btAnteriorAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAnteriorAviso.FlatAppearance.BorderSize = 0;
            this.btAnteriorAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnteriorAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnteriorAviso.ForeColor = System.Drawing.Color.White;
            this.btAnteriorAviso.Location = new System.Drawing.Point(13, 145);
            this.btAnteriorAviso.Name = "btAnteriorAviso";
            this.btAnteriorAviso.Size = new System.Drawing.Size(38, 35);
            this.btAnteriorAviso.TabIndex = 76;
            this.btAnteriorAviso.Text = "<";
            this.btAnteriorAviso.UseVisualStyleBackColor = false;
            this.btAnteriorAviso.Click += new System.EventHandler(this.btAnteriorAviso_Click);
            // 
            // lblQuadroDeAvisos
            // 
            this.lblQuadroDeAvisos.AutoSize = true;
            this.lblQuadroDeAvisos.Font = new System.Drawing.Font("Josefin Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuadroDeAvisos.ForeColor = System.Drawing.Color.White;
            this.lblQuadroDeAvisos.Location = new System.Drawing.Point(7, 54);
            this.lblQuadroDeAvisos.Name = "lblQuadroDeAvisos";
            this.lblQuadroDeAvisos.Size = new System.Drawing.Size(246, 43);
            this.lblQuadroDeAvisos.TabIndex = 77;
            this.lblQuadroDeAvisos.Text = "Quadro de avisos";
            // 
            // dataMonthCalendar
            // 
            this.dataMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.tab_avisosBindingSource, "Data", true));
            this.dataMonthCalendar.Font = new System.Drawing.Font("Josefin Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMonthCalendar.Location = new System.Drawing.Point(792, 9);
            this.dataMonthCalendar.Name = "dataMonthCalendar";
            this.dataMonthCalendar.TabIndex = 79;
            // 
            // btSalvarAviso
            // 
            this.btSalvarAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.btSalvarAviso.FlatAppearance.BorderSize = 0;
            this.btSalvarAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarAviso.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarAviso.ForeColor = System.Drawing.Color.White;
            this.btSalvarAviso.Location = new System.Drawing.Point(901, 176);
            this.btSalvarAviso.Name = "btSalvarAviso";
            this.btSalvarAviso.Size = new System.Drawing.Size(120, 44);
            this.btSalvarAviso.TabIndex = 80;
            this.btSalvarAviso.Text = "Salvar";
            this.btSalvarAviso.UseVisualStyleBackColor = false;
            this.btSalvarAviso.Click += new System.EventHandler(this.btSalvarAviso_Click);
            // 
            // ucInício
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btSalvarAviso);
            this.Controls.Add(this.dataMonthCalendar);
            this.Controls.Add(this.lblQuadroDeAvisos);
            this.Controls.Add(this.btAnteriorAviso);
            this.Controls.Add(this.btProximoAviso);
            this.Controls.Add(this.dataLabel1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "ucInício";
            this.Size = new System.Drawing.Size(1028, 653);
            this.Load += new System.EventHandler(this.ucInício_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_avisosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDMARCAFACILDataSet bDMARCAFACILDataSet;
        private System.Windows.Forms.BindingSource tab_avisosBindingSource;
        private BDMARCAFACILDataSetTableAdapters.tab_avisosTableAdapter tab_avisosTableAdapter;
        private BDMARCAFACILDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Label dataLabel1;
        private System.Windows.Forms.Button btProximoAviso;
        private System.Windows.Forms.Button btAnteriorAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avisosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblQuadroDeAvisos;
        private System.Windows.Forms.MonthCalendar dataMonthCalendar;
        private System.Windows.Forms.Button btSalvarAviso;
    }
}
