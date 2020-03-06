namespace MarcaFácil
{
    partial class Pacientes
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
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label data_de_NascimentoLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label estado_CivilLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label nomeConvênioLabel;
            this.btEditarPaciente = new System.Windows.Forms.Button();
            this.btCancelarPacienteEdit = new System.Windows.Forms.Button();
            this.btDeletarPaciente = new System.Windows.Forms.Button();
            this.btSalvarPaciente = new System.Windows.Forms.Button();
            this.btProximoColab = new System.Windows.Forms.Button();
            this.btAnteriorColab = new System.Windows.Forms.Button();
            this.btNovoPaciente = new System.Windows.Forms.Button();
            this.painelCadastroPaciente = new System.Windows.Forms.Panel();
            this.nomeConvênioComboBox = new System.Windows.Forms.ComboBox();
            this.tab_pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDMARCAFACILDataSet = new MarcaFácil.BDMARCAFACILDataSet();
            this.idpacienteLabel1 = new System.Windows.Forms.Label();
            this.pacienteTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_de_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.estado_CivilComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.lblTituloPaciente = new System.Windows.Forms.Label();
            this.tab_pacienteTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_pacienteTableAdapter();
            this.tableAdapterManager = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager();
            idpacienteLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            data_de_NascimentoLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            estado_CivilLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            nomeConvênioLabel = new System.Windows.Forms.Label();
            this.painelCadastroPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idpacienteLabel.ForeColor = System.Drawing.Color.White;
            idpacienteLabel.Location = new System.Drawing.Point(745, 21);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(43, 30);
            idpacienteLabel.TabIndex = 0;
            idpacienteLabel.Text = "ID :";
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pacienteLabel.ForeColor = System.Drawing.Color.White;
            pacienteLabel.Location = new System.Drawing.Point(12, 21);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(76, 30);
            pacienteLabel.TabIndex = 2;
            pacienteLabel.Text = "Nome :";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.ForeColor = System.Drawing.Color.White;
            cPFLabel.Location = new System.Drawing.Point(28, 100);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(45, 25);
            cPFLabel.TabIndex = 4;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rGLabel.ForeColor = System.Drawing.Color.White;
            rGLabel.Location = new System.Drawing.Point(31, 69);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(38, 25);
            rGLabel.TabIndex = 6;
            rGLabel.Text = "RG:";
            // 
            // data_de_NascimentoLabel
            // 
            data_de_NascimentoLabel.AutoSize = true;
            data_de_NascimentoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_de_NascimentoLabel.ForeColor = System.Drawing.Color.White;
            data_de_NascimentoLabel.Location = new System.Drawing.Point(328, 69);
            data_de_NascimentoLabel.Name = "data_de_NascimentoLabel";
            data_de_NascimentoLabel.Size = new System.Drawing.Size(163, 25);
            data_de_NascimentoLabel.TabIndex = 8;
            data_de_NascimentoLabel.Text = "Data de Nascimento:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endereçoLabel.ForeColor = System.Drawing.Color.White;
            endereçoLabel.Location = new System.Drawing.Point(10, 200);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(81, 25);
            endereçoLabel.TabIndex = 10;
            endereçoLabel.Text = "Endereço:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.Color.White;
            bairroLabel.Location = new System.Drawing.Point(21, 269);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(59, 25);
            bairroLabel.TabIndex = 12;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.Color.White;
            cidadeLabel.Location = new System.Drawing.Point(377, 149);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(65, 25);
            cidadeLabel.TabIndex = 14;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.ForeColor = System.Drawing.Color.White;
            estadoLabel.Location = new System.Drawing.Point(734, 149);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(65, 25);
            estadoLabel.TabIndex = 16;
            estadoLabel.Text = "Estado:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.Color.White;
            sexoLabel.Location = new System.Drawing.Point(385, 100);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(48, 25);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // estado_CivilLabel
            // 
            estado_CivilLabel.AutoSize = true;
            estado_CivilLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estado_CivilLabel.ForeColor = System.Drawing.Color.White;
            estado_CivilLabel.Location = new System.Drawing.Point(716, 100);
            estado_CivilLabel.Name = "estado_CivilLabel";
            estado_CivilLabel.Size = new System.Drawing.Size(101, 25);
            estado_CivilLabel.TabIndex = 20;
            estado_CivilLabel.Text = "Estado Civil:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.ForeColor = System.Drawing.Color.White;
            telefoneLabel.Location = new System.Drawing.Point(13, 335);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(74, 25);
            telefoneLabel.TabIndex = 24;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.ForeColor = System.Drawing.Color.White;
            celularLabel.Location = new System.Drawing.Point(380, 335);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(66, 25);
            celularLabel.TabIndex = 26;
            celularLabel.Text = "Celular:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.ForeColor = System.Drawing.Color.White;
            e_mailLabel.Location = new System.Drawing.Point(20, 368);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(60, 25);
            e_mailLabel.TabIndex = 28;
            e_mailLabel.Text = "E-mail:";
            // 
            // nomeConvênioLabel
            // 
            nomeConvênioLabel.AutoSize = true;
            nomeConvênioLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeConvênioLabel.ForeColor = System.Drawing.Color.White;
            nomeConvênioLabel.Location = new System.Drawing.Point(2, 152);
            nomeConvênioLabel.Name = "nomeConvênioLabel";
            nomeConvênioLabel.Size = new System.Drawing.Size(130, 25);
            nomeConvênioLabel.TabIndex = 62;
            nomeConvênioLabel.Text = "Nome Convênio:";
            // 
            // btEditarPaciente
            // 
            this.btEditarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btEditarPaciente.FlatAppearance.BorderSize = 0;
            this.btEditarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarPaciente.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarPaciente.ForeColor = System.Drawing.Color.White;
            this.btEditarPaciente.Location = new System.Drawing.Point(16, 579);
            this.btEditarPaciente.Name = "btEditarPaciente";
            this.btEditarPaciente.Size = new System.Drawing.Size(120, 44);
            this.btEditarPaciente.TabIndex = 84;
            this.btEditarPaciente.Text = "Editar";
            this.btEditarPaciente.UseVisualStyleBackColor = false;
            this.btEditarPaciente.Click += new System.EventHandler(this.btEditarPaciente_Click);
            // 
            // btCancelarPacienteEdit
            // 
            this.btCancelarPacienteEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btCancelarPacienteEdit.FlatAppearance.BorderSize = 0;
            this.btCancelarPacienteEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarPacienteEdit.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarPacienteEdit.ForeColor = System.Drawing.Color.White;
            this.btCancelarPacienteEdit.Location = new System.Drawing.Point(295, 579);
            this.btCancelarPacienteEdit.Name = "btCancelarPacienteEdit";
            this.btCancelarPacienteEdit.Size = new System.Drawing.Size(109, 44);
            this.btCancelarPacienteEdit.TabIndex = 83;
            this.btCancelarPacienteEdit.Text = "Cancelar";
            this.btCancelarPacienteEdit.UseVisualStyleBackColor = false;
            this.btCancelarPacienteEdit.Click += new System.EventHandler(this.btCancelarPacienteEdit_Click);
            // 
            // btDeletarPaciente
            // 
            this.btDeletarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.btDeletarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeletarPaciente.FlatAppearance.BorderSize = 0;
            this.btDeletarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletarPaciente.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarPaciente.ForeColor = System.Drawing.Color.White;
            this.btDeletarPaciente.Location = new System.Drawing.Point(426, 579);
            this.btDeletarPaciente.Name = "btDeletarPaciente";
            this.btDeletarPaciente.Size = new System.Drawing.Size(109, 44);
            this.btDeletarPaciente.TabIndex = 82;
            this.btDeletarPaciente.Text = "Deletar";
            this.btDeletarPaciente.UseVisualStyleBackColor = false;
            this.btDeletarPaciente.Click += new System.EventHandler(this.btDeletarPaciente_Click);
            // 
            // btSalvarPaciente
            // 
            this.btSalvarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.btSalvarPaciente.FlatAppearance.BorderSize = 0;
            this.btSalvarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarPaciente.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarPaciente.ForeColor = System.Drawing.Color.White;
            this.btSalvarPaciente.Location = new System.Drawing.Point(558, 579);
            this.btSalvarPaciente.Name = "btSalvarPaciente";
            this.btSalvarPaciente.Size = new System.Drawing.Size(120, 44);
            this.btSalvarPaciente.TabIndex = 76;
            this.btSalvarPaciente.Text = "Salvar";
            this.btSalvarPaciente.UseVisualStyleBackColor = false;
            this.btSalvarPaciente.Click += new System.EventHandler(this.btSalvarPaciente_Click);
            // 
            // btProximoColab
            // 
            this.btProximoColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btProximoColab.FlatAppearance.BorderSize = 0;
            this.btProximoColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximoColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoColab.ForeColor = System.Drawing.Color.White;
            this.btProximoColab.Location = new System.Drawing.Point(253, 78);
            this.btProximoColab.Name = "btProximoColab";
            this.btProximoColab.Size = new System.Drawing.Size(38, 35);
            this.btProximoColab.TabIndex = 81;
            this.btProximoColab.Text = ">";
            this.btProximoColab.UseVisualStyleBackColor = false;
            this.btProximoColab.Click += new System.EventHandler(this.btProximoColab_Click);
            // 
            // btAnteriorColab
            // 
            this.btAnteriorColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAnteriorColab.FlatAppearance.BorderSize = 0;
            this.btAnteriorColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnteriorColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnteriorColab.ForeColor = System.Drawing.Color.White;
            this.btAnteriorColab.Location = new System.Drawing.Point(16, 78);
            this.btAnteriorColab.Name = "btAnteriorColab";
            this.btAnteriorColab.Size = new System.Drawing.Size(38, 35);
            this.btAnteriorColab.TabIndex = 80;
            this.btAnteriorColab.Text = "<";
            this.btAnteriorColab.UseVisualStyleBackColor = false;
            this.btAnteriorColab.Click += new System.EventHandler(this.btAnteriorColab_Click);
            // 
            // btNovoPaciente
            // 
            this.btNovoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btNovoPaciente.FlatAppearance.BorderSize = 0;
            this.btNovoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoPaciente.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoPaciente.ForeColor = System.Drawing.Color.White;
            this.btNovoPaciente.Location = new System.Drawing.Point(158, 578);
            this.btNovoPaciente.Name = "btNovoPaciente";
            this.btNovoPaciente.Size = new System.Drawing.Size(120, 44);
            this.btNovoPaciente.TabIndex = 79;
            this.btNovoPaciente.Text = "Novo";
            this.btNovoPaciente.UseVisualStyleBackColor = false;
            this.btNovoPaciente.Click += new System.EventHandler(this.btNovoPaciente_Click);
            // 
            // painelCadastroPaciente
            // 
            this.painelCadastroPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.painelCadastroPaciente.Controls.Add(nomeConvênioLabel);
            this.painelCadastroPaciente.Controls.Add(this.nomeConvênioComboBox);
            this.painelCadastroPaciente.Controls.Add(idpacienteLabel);
            this.painelCadastroPaciente.Controls.Add(this.idpacienteLabel1);
            this.painelCadastroPaciente.Controls.Add(pacienteLabel);
            this.painelCadastroPaciente.Controls.Add(this.pacienteTextBox);
            this.painelCadastroPaciente.Controls.Add(cPFLabel);
            this.painelCadastroPaciente.Controls.Add(this.cPFMaskedTextBox);
            this.painelCadastroPaciente.Controls.Add(rGLabel);
            this.painelCadastroPaciente.Controls.Add(this.rGMaskedTextBox);
            this.painelCadastroPaciente.Controls.Add(data_de_NascimentoLabel);
            this.painelCadastroPaciente.Controls.Add(this.data_de_NascimentoDateTimePicker);
            this.painelCadastroPaciente.Controls.Add(endereçoLabel);
            this.painelCadastroPaciente.Controls.Add(this.endereçoTextBox);
            this.painelCadastroPaciente.Controls.Add(bairroLabel);
            this.painelCadastroPaciente.Controls.Add(this.bairroTextBox);
            this.painelCadastroPaciente.Controls.Add(cidadeLabel);
            this.painelCadastroPaciente.Controls.Add(this.cidadeTextBox);
            this.painelCadastroPaciente.Controls.Add(estadoLabel);
            this.painelCadastroPaciente.Controls.Add(this.estadoComboBox);
            this.painelCadastroPaciente.Controls.Add(sexoLabel);
            this.painelCadastroPaciente.Controls.Add(this.sexoComboBox);
            this.painelCadastroPaciente.Controls.Add(estado_CivilLabel);
            this.painelCadastroPaciente.Controls.Add(this.estado_CivilComboBox);
            this.painelCadastroPaciente.Controls.Add(telefoneLabel);
            this.painelCadastroPaciente.Controls.Add(this.telefoneMaskedTextBox);
            this.painelCadastroPaciente.Controls.Add(celularLabel);
            this.painelCadastroPaciente.Controls.Add(this.celularMaskedTextBox);
            this.painelCadastroPaciente.Controls.Add(e_mailLabel);
            this.painelCadastroPaciente.Controls.Add(this.e_mailTextBox);
            this.painelCadastroPaciente.Font = new System.Drawing.Font("Josefin Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelCadastroPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelCadastroPaciente.Location = new System.Drawing.Point(16, 119);
            this.painelCadastroPaciente.Name = "painelCadastroPaciente";
            this.painelCadastroPaciente.Size = new System.Drawing.Size(996, 441);
            this.painelCadastroPaciente.TabIndex = 78;
            // 
            // nomeConvênioComboBox
            // 
            this.nomeConvênioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "NomeConvênio", true));
            this.nomeConvênioComboBox.FormattingEnabled = true;
            this.nomeConvênioComboBox.Items.AddRange(new object[] {
            "HAOC",
            "UNIMED",
            "SAMARITANO"});
            this.nomeConvênioComboBox.Location = new System.Drawing.Point(162, 148);
            this.nomeConvênioComboBox.Name = "nomeConvênioComboBox";
            this.nomeConvênioComboBox.Size = new System.Drawing.Size(121, 26);
            this.nomeConvênioComboBox.TabIndex = 63;
            // 
            // tab_pacienteBindingSource
            // 
            this.tab_pacienteBindingSource.DataMember = "tab_paciente";
            this.tab_pacienteBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // bDMARCAFACILDataSet
            // 
            this.bDMARCAFACILDataSet.DataSetName = "BDMARCAFACILDataSet";
            this.bDMARCAFACILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idpacienteLabel1
            // 
            this.idpacienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "idpaciente", true));
            this.idpacienteLabel1.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpacienteLabel1.ForeColor = System.Drawing.Color.White;
            this.idpacienteLabel1.Location = new System.Drawing.Point(793, 18);
            this.idpacienteLabel1.Name = "idpacienteLabel1";
            this.idpacienteLabel1.Size = new System.Drawing.Size(200, 37);
            this.idpacienteLabel1.TabIndex = 1;
            this.idpacienteLabel1.Text = "label1";
            // 
            // pacienteTextBox
            // 
            this.pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Paciente", true));
            this.pacienteTextBox.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteTextBox.Location = new System.Drawing.Point(122, 18);
            this.pacienteTextBox.Multiline = true;
            this.pacienteTextBox.Name = "pacienteTextBox";
            this.pacienteTextBox.Size = new System.Drawing.Size(531, 37);
            this.pacienteTextBox.TabIndex = 3;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(122, 101);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.cPFMaskedTextBox.TabIndex = 5;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "RG", true));
            this.rGMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(122, 70);
            this.rGMaskedTextBox.Mask = "00.000.000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.rGMaskedTextBox.TabIndex = 7;
            // 
            // data_de_NascimentoDateTimePicker
            // 
            this.data_de_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tab_pacienteBindingSource, "Data de Nascimento", true));
            this.data_de_NascimentoDateTimePicker.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_de_NascimentoDateTimePicker.Location = new System.Drawing.Point(497, 70);
            this.data_de_NascimentoDateTimePicker.Name = "data_de_NascimentoDateTimePicker";
            this.data_de_NascimentoDateTimePicker.Size = new System.Drawing.Size(339, 23);
            this.data_de_NascimentoDateTimePicker.TabIndex = 9;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Endereço", true));
            this.endereçoTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereçoTextBox.Location = new System.Drawing.Point(122, 197);
            this.endereçoTextBox.Multiline = true;
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(680, 67);
            this.endereçoTextBox.TabIndex = 11;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(122, 270);
            this.bairroTextBox.Multiline = true;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(200, 31);
            this.bairroTextBox.TabIndex = 13;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.Location = new System.Drawing.Point(497, 146);
            this.cidadeTextBox.Multiline = true;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 31);
            this.cidadeTextBox.TabIndex = 15;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Estado", true));
            this.estadoComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(833, 145);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 33);
            this.estadoComboBox.TabIndex = 17;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Sexo", true));
            this.sexoComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(497, 96);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 33);
            this.sexoComboBox.TabIndex = 19;
            // 
            // estado_CivilComboBox
            // 
            this.estado_CivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Estado Civil", true));
            this.estado_CivilComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_CivilComboBox.FormattingEnabled = true;
            this.estado_CivilComboBox.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.estado_CivilComboBox.Location = new System.Drawing.Point(833, 96);
            this.estado_CivilComboBox.Name = "estado_CivilComboBox";
            this.estado_CivilComboBox.Size = new System.Drawing.Size(121, 33);
            this.estado_CivilComboBox.TabIndex = 21;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(122, 336);
            this.telefoneMaskedTextBox.Mask = "(00)0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.telefoneMaskedTextBox.TabIndex = 25;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "Celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(497, 336);
            this.celularMaskedTextBox.Mask = "(00)00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.celularMaskedTextBox.TabIndex = 27;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pacienteBindingSource, "E-mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.Location = new System.Drawing.Point(122, 369);
            this.e_mailTextBox.Multiline = true;
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(200, 31);
            this.e_mailTextBox.TabIndex = 29;
            // 
            // lblTituloPaciente
            // 
            this.lblTituloPaciente.AutoSize = true;
            this.lblTituloPaciente.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPaciente.ForeColor = System.Drawing.Color.White;
            this.lblTituloPaciente.Location = new System.Drawing.Point(91, 76);
            this.lblTituloPaciente.Name = "lblTituloPaciente";
            this.lblTituloPaciente.Size = new System.Drawing.Size(115, 38);
            this.lblTituloPaciente.TabIndex = 77;
            this.lblTituloPaciente.Text = "Paciente";
            // 
            // tab_pacienteTableAdapter
            // 
            this.tab_pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tab_agendamentoTableAdapter = null;
            this.tableAdapterManager.tab_avisosTableAdapter = null;
            this.tableAdapterManager.tab_colaboradoresTableAdapter = null;
            this.tableAdapterManager.tab_pacienteTableAdapter = this.tab_pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btEditarPaciente);
            this.Controls.Add(this.btCancelarPacienteEdit);
            this.Controls.Add(this.btDeletarPaciente);
            this.Controls.Add(this.btSalvarPaciente);
            this.Controls.Add(this.btProximoColab);
            this.Controls.Add(this.btAnteriorColab);
            this.Controls.Add(this.btNovoPaciente);
            this.Controls.Add(this.painelCadastroPaciente);
            this.Controls.Add(this.lblTituloPaciente);
            this.Name = "Pacientes";
            this.Size = new System.Drawing.Size(1019, 653);
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.painelCadastroPaciente.ResumeLayout(false);
            this.painelCadastroPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEditarPaciente;
        private System.Windows.Forms.Button btCancelarPacienteEdit;
        private System.Windows.Forms.Button btDeletarPaciente;
        private System.Windows.Forms.Button btSalvarPaciente;
        private System.Windows.Forms.Button btProximoColab;
        private System.Windows.Forms.Button btAnteriorColab;
        private System.Windows.Forms.Button btNovoPaciente;
        private System.Windows.Forms.Panel painelCadastroPaciente;
        private System.Windows.Forms.Label lblTituloPaciente;
        private BDMARCAFACILDataSet bDMARCAFACILDataSet;
        private System.Windows.Forms.BindingSource tab_pacienteBindingSource;
        private BDMARCAFACILDataSetTableAdapters.tab_pacienteTableAdapter tab_pacienteTableAdapter;
        private BDMARCAFACILDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idpacienteLabel1;
        private System.Windows.Forms.TextBox pacienteTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.DateTimePicker data_de_NascimentoDateTimePicker;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox estado_CivilComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.ComboBox nomeConvênioComboBox;
    }
}
