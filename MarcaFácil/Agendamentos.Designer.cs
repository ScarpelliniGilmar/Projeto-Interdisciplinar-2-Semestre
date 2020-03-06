namespace MarcaFácil
{
    partial class Agendamentos
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
            System.Windows.Forms.Label idagendaLabel;
            System.Windows.Forms.Label nomeColaboradorLabel;
            System.Windows.Forms.Label dataConsultaLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabagendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDMARCAFACILDataSet = new MarcaFácil.BDMARCAFACILDataSet();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tab_agendamentoTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_agendamentoTableAdapter();
            this.tab_colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_colaboradoresTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_colaboradoresTableAdapter();
            this.tableAdapterManager = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager();
            this.tab_pacienteTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_pacienteTableAdapter();
            this.tab_pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btProximoAgend = new System.Windows.Forms.Button();
            this.btAnteriorAgend = new System.Windows.Forms.Button();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.GroupBoxdadosDaConsulta = new System.Windows.Forms.GroupBox();
            this.idagendaLabel1 = new System.Windows.Forms.Label();
            this.dataConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pacienteComboBox = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.nomeColaboradorComboBox = new System.Windows.Forms.ComboBox();
            this.viewAgendamentos = new ADGV.AdvancedDataGridView();
            this.idagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcolaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idagendaLabel = new System.Windows.Forms.Label();
            nomeColaboradorLabel = new System.Windows.Forms.Label();
            dataConsultaLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabagendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pacienteBindingSource)).BeginInit();
            this.GroupBoxdadosDaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabagendamentoBindingSource
            // 
            this.tabagendamentoBindingSource.DataMember = "tab_agendamento";
            this.tabagendamentoBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // bDMARCAFACILDataSet
            // 
            this.bDMARCAFACILDataSet.DataSetName = "BDMARCAFACILDataSet";
            this.bDMARCAFACILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(577, 587);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(109, 44);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(39, 587);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(109, 44);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.btDeletar.FlatAppearance.BorderSize = 0;
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.ForeColor = System.Drawing.Color.White;
            this.btDeletar.Location = new System.Drawing.Point(442, 587);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(109, 44);
            this.btDeletar.TabIndex = 3;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(302, 587);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 44);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tab_agendamentoTableAdapter
            // 
            this.tab_agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tab_colaboradoresBindingSource
            // 
            this.tab_colaboradoresBindingSource.DataMember = "tab_colaboradores";
            this.tab_colaboradoresBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // tab_colaboradoresTableAdapter
            // 
            this.tab_colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tab_agendamentoTableAdapter = this.tab_agendamentoTableAdapter;
            this.tableAdapterManager.tab_avisosTableAdapter = null;
            this.tableAdapterManager.tab_colaboradoresTableAdapter = this.tab_colaboradoresTableAdapter;
            this.tableAdapterManager.tab_pacienteTableAdapter = this.tab_pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tab_pacienteTableAdapter
            // 
            this.tab_pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tab_pacienteBindingSource
            // 
            this.tab_pacienteBindingSource.DataMember = "tab_paciente";
            this.tab_pacienteBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // btProximoAgend
            // 
            this.btProximoAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btProximoAgend.FlatAppearance.BorderSize = 0;
            this.btProximoAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximoAgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoAgend.ForeColor = System.Drawing.Color.White;
            this.btProximoAgend.Location = new System.Drawing.Point(276, 22);
            this.btProximoAgend.Name = "btProximoAgend";
            this.btProximoAgend.Size = new System.Drawing.Size(38, 35);
            this.btProximoAgend.TabIndex = 74;
            this.btProximoAgend.Text = ">";
            this.btProximoAgend.UseVisualStyleBackColor = false;
            this.btProximoAgend.Click += new System.EventHandler(this.btProximoAgend_Click);
            // 
            // btAnteriorAgend
            // 
            this.btAnteriorAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAnteriorAgend.FlatAppearance.BorderSize = 0;
            this.btAnteriorAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnteriorAgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnteriorAgend.ForeColor = System.Drawing.Color.White;
            this.btAnteriorAgend.Location = new System.Drawing.Point(39, 22);
            this.btAnteriorAgend.Name = "btAnteriorAgend";
            this.btAnteriorAgend.Size = new System.Drawing.Size(38, 35);
            this.btAnteriorAgend.TabIndex = 73;
            this.btAnteriorAgend.Text = "<";
            this.btAnteriorAgend.UseVisualStyleBackColor = false;
            this.btAnteriorAgend.Click += new System.EventHandler(this.btAnteriorAgend_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.White;
            this.lblAgenda.Location = new System.Drawing.Point(83, 20);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(188, 38);
            this.lblAgenda.TabIndex = 72;
            this.lblAgenda.Text = "Agendamentos";
            // 
            // GroupBoxdadosDaConsulta
            // 
            this.GroupBoxdadosDaConsulta.Controls.Add(this.nomeColaboradorComboBox);
            this.GroupBoxdadosDaConsulta.Controls.Add(horaLabel);
            this.GroupBoxdadosDaConsulta.Controls.Add(this.horaTextBox);
            this.GroupBoxdadosDaConsulta.Controls.Add(idagendaLabel);
            this.GroupBoxdadosDaConsulta.Controls.Add(this.idagendaLabel1);
            this.GroupBoxdadosDaConsulta.Controls.Add(nomeColaboradorLabel);
            this.GroupBoxdadosDaConsulta.Controls.Add(dataConsultaLabel);
            this.GroupBoxdadosDaConsulta.Controls.Add(this.dataConsultaDateTimePicker);
            this.GroupBoxdadosDaConsulta.Controls.Add(this.pacienteComboBox);
            this.GroupBoxdadosDaConsulta.Controls.Add(pacienteLabel);
            this.GroupBoxdadosDaConsulta.Font = new System.Drawing.Font("Josefin Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxdadosDaConsulta.ForeColor = System.Drawing.Color.White;
            this.GroupBoxdadosDaConsulta.Location = new System.Drawing.Point(39, 353);
            this.GroupBoxdadosDaConsulta.Name = "GroupBoxdadosDaConsulta";
            this.GroupBoxdadosDaConsulta.Size = new System.Drawing.Size(832, 217);
            this.GroupBoxdadosDaConsulta.TabIndex = 81;
            this.GroupBoxdadosDaConsulta.TabStop = false;
            this.GroupBoxdadosDaConsulta.Text = "Dados da consulta";
            // 
            // idagendaLabel
            // 
            idagendaLabel.AutoSize = true;
            idagendaLabel.Location = new System.Drawing.Point(570, 18);
            idagendaLabel.Name = "idagendaLabel";
            idagendaLabel.Size = new System.Drawing.Size(112, 24);
            idagendaLabel.TabIndex = 80;
            idagendaLabel.Text = "ID da agenda:";
            // 
            // idagendaLabel1
            // 
            this.idagendaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabagendamentoBindingSource, "idagenda", true));
            this.idagendaLabel1.Location = new System.Drawing.Point(700, 18);
            this.idagendaLabel1.Name = "idagendaLabel1";
            this.idagendaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idagendaLabel1.TabIndex = 81;
            this.idagendaLabel1.Text = "label1";
            // 
            // nomeColaboradorLabel
            // 
            nomeColaboradorLabel.AutoSize = true;
            nomeColaboradorLabel.Location = new System.Drawing.Point(8, 58);
            nomeColaboradorLabel.Name = "nomeColaboradorLabel";
            nomeColaboradorLabel.Size = new System.Drawing.Size(150, 24);
            nomeColaboradorLabel.TabIndex = 74;
            nomeColaboradorLabel.Text = "Nome Colaborador:";
            // 
            // dataConsultaLabel
            // 
            dataConsultaLabel.AutoSize = true;
            dataConsultaLabel.Location = new System.Drawing.Point(477, 58);
            dataConsultaLabel.Name = "dataConsultaLabel";
            dataConsultaLabel.Size = new System.Drawing.Size(117, 24);
            dataConsultaLabel.TabIndex = 77;
            dataConsultaLabel.Text = "Data Consulta:";
            // 
            // dataConsultaDateTimePicker
            // 
            this.dataConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabagendamentoBindingSource, "DataConsulta", true));
            this.dataConsultaDateTimePicker.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataConsultaDateTimePicker.Location = new System.Drawing.Point(600, 60);
            this.dataConsultaDateTimePicker.Name = "dataConsultaDateTimePicker";
            this.dataConsultaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataConsultaDateTimePicker.TabIndex = 78;
            // 
            // pacienteComboBox
            // 
            this.pacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabagendamentoBindingSource, "Paciente", true));
            this.pacienteComboBox.DataSource = this.tab_pacienteBindingSource;
            this.pacienteComboBox.DisplayMember = "Paciente";
            this.pacienteComboBox.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteComboBox.FormattingEnabled = true;
            this.pacienteComboBox.Location = new System.Drawing.Point(600, 113);
            this.pacienteComboBox.Name = "pacienteComboBox";
            this.pacienteComboBox.Size = new System.Drawing.Size(200, 32);
            this.pacienteComboBox.TabIndex = 77;
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Location = new System.Drawing.Point(520, 116);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(74, 24);
            pacienteLabel.TabIndex = 76;
            pacienteLabel.Text = "Paciente:";
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Location = new System.Drawing.Point(171, 587);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(109, 44);
            this.btNovo.TabIndex = 82;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(118, 143);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(49, 24);
            horaLabel.TabIndex = 81;
            horaLabel.Text = "Hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabagendamentoBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(173, 140);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(100, 22);
            this.horaTextBox.TabIndex = 82;
            // 
            // nomeColaboradorComboBox
            // 
            this.nomeColaboradorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabagendamentoBindingSource, "NomeColaborador", true));
            this.nomeColaboradorComboBox.DataSource = this.tab_colaboradoresBindingSource;
            this.nomeColaboradorComboBox.DisplayMember = "NomeColaborador";
            this.nomeColaboradorComboBox.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeColaboradorComboBox.FormattingEnabled = true;
            this.nomeColaboradorComboBox.Location = new System.Drawing.Point(173, 55);
            this.nomeColaboradorComboBox.Name = "nomeColaboradorComboBox";
            this.nomeColaboradorComboBox.Size = new System.Drawing.Size(209, 32);
            this.nomeColaboradorComboBox.TabIndex = 83;
            // 
            // viewAgendamentos
            // 
            this.viewAgendamentos.AllowUserToOrderColumns = true;
            this.viewAgendamentos.AutoGenerateColumns = false;
            this.viewAgendamentos.AutoGenerateContextFilters = true;
            this.viewAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendaDataGridViewTextBoxColumn,
            this.idcolaboradorDataGridViewTextBoxColumn,
            this.nomeColaboradorDataGridViewTextBoxColumn,
            this.idpacienteDataGridViewTextBoxColumn,
            this.pacienteDataGridViewTextBoxColumn,
            this.dataConsultaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.viewAgendamentos.DataSource = this.tabagendamentoBindingSource;
            this.viewAgendamentos.DateWithTime = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Josefin Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewAgendamentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.viewAgendamentos.Location = new System.Drawing.Point(39, 61);
            this.viewAgendamentos.Name = "viewAgendamentos";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.viewAgendamentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.viewAgendamentos.Size = new System.Drawing.Size(935, 283);
            this.viewAgendamentos.TabIndex = 87;
            this.viewAgendamentos.TimeFilter = false;
            // 
            // idagendaDataGridViewTextBoxColumn
            // 
            this.idagendaDataGridViewTextBoxColumn.DataPropertyName = "idagenda";
            this.idagendaDataGridViewTextBoxColumn.HeaderText = "idagenda";
            this.idagendaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idagendaDataGridViewTextBoxColumn.Name = "idagendaDataGridViewTextBoxColumn";
            this.idagendaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idagendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcolaboradorDataGridViewTextBoxColumn
            // 
            this.idcolaboradorDataGridViewTextBoxColumn.DataPropertyName = "idcolaborador";
            this.idcolaboradorDataGridViewTextBoxColumn.HeaderText = "idcolaborador";
            this.idcolaboradorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idcolaboradorDataGridViewTextBoxColumn.Name = "idcolaboradorDataGridViewTextBoxColumn";
            this.idcolaboradorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idcolaboradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeColaboradorDataGridViewTextBoxColumn
            // 
            this.nomeColaboradorDataGridViewTextBoxColumn.DataPropertyName = "NomeColaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.HeaderText = "NomeColaborador";
            this.nomeColaboradorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomeColaboradorDataGridViewTextBoxColumn.Name = "nomeColaboradorDataGridViewTextBoxColumn";
            this.nomeColaboradorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nomeColaboradorDataGridViewTextBoxColumn.Width = 230;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "idpaciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "idpaciente";
            this.idpacienteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            this.idpacienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idpacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            this.pacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            this.pacienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pacienteDataGridViewTextBoxColumn.Width = 230;
            // 
            // dataConsultaDataGridViewTextBoxColumn
            // 
            this.dataConsultaDataGridViewTextBoxColumn.DataPropertyName = "DataConsulta";
            this.dataConsultaDataGridViewTextBoxColumn.HeaderText = "DataConsulta";
            this.dataConsultaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dataConsultaDataGridViewTextBoxColumn.Name = "dataConsultaDataGridViewTextBoxColumn";
            this.dataConsultaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataConsultaDataGridViewTextBoxColumn.Width = 230;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.horaDataGridViewTextBoxColumn.Width = 230;
            // 
            // Agendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.viewAgendamentos);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.GroupBoxdadosDaConsulta);
            this.Controls.Add(this.btProximoAgend);
            this.Controls.Add(this.btAnteriorAgend);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalvar);
            this.Name = "Agendamentos";
            this.Size = new System.Drawing.Size(1019, 653);
            this.Load += new System.EventHandler(this.Agendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabagendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pacienteBindingSource)).EndInit();
            this.GroupBoxdadosDaConsulta.ResumeLayout(false);
            this.GroupBoxdadosDaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tabagendamentoBindingSource;
        private BDMARCAFACILDataSet bDMARCAFACILDataSet;
        private BDMARCAFACILDataSetTableAdapters.tab_agendamentoTableAdapter tab_agendamentoTableAdapter;
        private System.Windows.Forms.BindingSource tab_colaboradoresBindingSource;
        private BDMARCAFACILDataSetTableAdapters.tab_colaboradoresTableAdapter tab_colaboradoresTableAdapter;
        private BDMARCAFACILDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDMARCAFACILDataSetTableAdapters.tab_pacienteTableAdapter tab_pacienteTableAdapter;
        private System.Windows.Forms.BindingSource tab_pacienteBindingSource;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btProximoAgend;
        private System.Windows.Forms.Button btAnteriorAgend;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.GroupBox GroupBoxdadosDaConsulta;
        private System.Windows.Forms.Label idagendaLabel1;
        private System.Windows.Forms.DateTimePicker dataConsultaDateTimePicker;
        private System.Windows.Forms.ComboBox pacienteComboBox;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.ComboBox nomeColaboradorComboBox;
        private ADGV.AdvancedDataGridView viewAgendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}
