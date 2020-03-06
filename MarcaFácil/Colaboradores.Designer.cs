namespace MarcaFácil
{
    partial class Colaboradores
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
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label data_de_NascimentoLabel;
            System.Windows.Forms.Label nomeColaboradorLabel;
            System.Windows.Forms.Label idcolaboradorLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label estado_CivilLabel;
            System.Windows.Forms.Label nomeConvênioLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            this.btCancelarColabEdit = new System.Windows.Forms.Button();
            this.btDeletarColab = new System.Windows.Forms.Button();
            this.btSalvarColab = new System.Windows.Forms.Button();
            this.btProximoColab = new System.Windows.Forms.Button();
            this.btAnteriorColab = new System.Windows.Forms.Button();
            this.btNovoColab = new System.Windows.Forms.Button();
            this.tab_colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDMARCAFACILDataSet = new MarcaFácil.BDMARCAFACILDataSet();
            this.lblCadastroColaboradores = new System.Windows.Forms.Label();
            this.btEditarColab = new System.Windows.Forms.Button();
            this.tab_colaboradoresTableAdapter = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.tab_colaboradoresTableAdapter();
            this.tableAdapterManager = new MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.data_de_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeColaboradorTextBox = new System.Windows.Forms.TextBox();
            this.idcolaboradorLabel1 = new System.Windows.Forms.Label();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.estado_CivilComboBox = new System.Windows.Forms.ComboBox();
            this.nomeConvênioComboBox = new System.Windows.Forms.ComboBox();
            this.PainelColab = new System.Windows.Forms.Panel();
            this.lblCRM = new System.Windows.Forms.Label();
            this.labelEspecialidade = new System.Windows.Forms.Label();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cRMTextBox = new System.Windows.Forms.TextBox();
            this.especialidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            celularLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            data_de_NascimentoLabel = new System.Windows.Forms.Label();
            nomeColaboradorLabel = new System.Windows.Forms.Label();
            idcolaboradorLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            estado_CivilLabel = new System.Windows.Forms.Label();
            nomeConvênioLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tab_colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).BeginInit();
            this.PainelColab.SuspendLayout();
            this.SuspendLayout();
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.ForeColor = System.Drawing.Color.White;
            celularLabel.Location = new System.Drawing.Point(379, 341);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(66, 25);
            celularLabel.TabIndex = 26;
            celularLabel.Text = "Celular:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.ForeColor = System.Drawing.Color.White;
            telefoneLabel.Location = new System.Drawing.Point(13, 341);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(74, 25);
            telefoneLabel.TabIndex = 24;
            telefoneLabel.Text = "Telefone:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.Color.White;
            bairroLabel.Location = new System.Drawing.Point(21, 246);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(59, 25);
            bairroLabel.TabIndex = 12;
            bairroLabel.Text = "Bairro:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endereçoLabel.ForeColor = System.Drawing.Color.White;
            endereçoLabel.Location = new System.Drawing.Point(10, 173);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(81, 25);
            endereçoLabel.TabIndex = 10;
            endereçoLabel.Text = "Endereço:";
            // 
            // data_de_NascimentoLabel
            // 
            data_de_NascimentoLabel.AutoSize = true;
            data_de_NascimentoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_de_NascimentoLabel.ForeColor = System.Drawing.Color.White;
            data_de_NascimentoLabel.Location = new System.Drawing.Point(331, 43);
            data_de_NascimentoLabel.Name = "data_de_NascimentoLabel";
            data_de_NascimentoLabel.Size = new System.Drawing.Size(163, 25);
            data_de_NascimentoLabel.TabIndex = 8;
            data_de_NascimentoLabel.Text = "Data de Nascimento:";
            // 
            // nomeColaboradorLabel
            // 
            nomeColaboradorLabel.AutoSize = true;
            nomeColaboradorLabel.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeColaboradorLabel.ForeColor = System.Drawing.Color.White;
            nomeColaboradorLabel.Location = new System.Drawing.Point(12, 4);
            nomeColaboradorLabel.Name = "nomeColaboradorLabel";
            nomeColaboradorLabel.Size = new System.Drawing.Size(76, 30);
            nomeColaboradorLabel.TabIndex = 2;
            nomeColaboradorLabel.Text = "Nome :";
            // 
            // idcolaboradorLabel
            // 
            idcolaboradorLabel.AutoSize = true;
            idcolaboradorLabel.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idcolaboradorLabel.ForeColor = System.Drawing.Color.White;
            idcolaboradorLabel.Location = new System.Drawing.Point(728, 4);
            idcolaboradorLabel.Name = "idcolaboradorLabel";
            idcolaboradorLabel.Size = new System.Drawing.Size(37, 30);
            idcolaboradorLabel.TabIndex = 0;
            idcolaboradorLabel.Text = "ID:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.ForeColor = System.Drawing.Color.White;
            e_mailLabel.Location = new System.Drawing.Point(20, 374);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(60, 25);
            e_mailLabel.TabIndex = 47;
            e_mailLabel.Text = "E-mail:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.Color.White;
            cidadeLabel.Location = new System.Drawing.Point(380, 130);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(65, 25);
            cidadeLabel.TabIndex = 37;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.ForeColor = System.Drawing.Color.White;
            estadoLabel.Location = new System.Drawing.Point(735, 130);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(65, 25);
            estadoLabel.TabIndex = 52;
            estadoLabel.Text = "Estado:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.Color.White;
            sexoLabel.Location = new System.Drawing.Point(396, 81);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(48, 25);
            sexoLabel.TabIndex = 53;
            sexoLabel.Text = "Sexo:";
            // 
            // estado_CivilLabel
            // 
            estado_CivilLabel.AutoSize = true;
            estado_CivilLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estado_CivilLabel.ForeColor = System.Drawing.Color.White;
            estado_CivilLabel.Location = new System.Drawing.Point(699, 81);
            estado_CivilLabel.Name = "estado_CivilLabel";
            estado_CivilLabel.Size = new System.Drawing.Size(101, 25);
            estado_CivilLabel.TabIndex = 54;
            estado_CivilLabel.Text = "Estado Civil:";
            // 
            // nomeConvênioLabel
            // 
            nomeConvênioLabel.AutoSize = true;
            nomeConvênioLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeConvênioLabel.ForeColor = System.Drawing.Color.White;
            nomeConvênioLabel.Location = new System.Drawing.Point(6, 130);
            nomeConvênioLabel.Name = "nomeConvênioLabel";
            nomeConvênioLabel.Size = new System.Drawing.Size(130, 25);
            nomeConvênioLabel.TabIndex = 55;
            nomeConvênioLabel.Text = "Nome Convênio:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoLabel.ForeColor = System.Drawing.Color.White;
            cargoLabel.Location = new System.Drawing.Point(30, 294);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(60, 25);
            cargoLabel.TabIndex = 56;
            cargoLabel.Text = "Cargo:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rGLabel.ForeColor = System.Drawing.Color.White;
            rGLabel.Location = new System.Drawing.Point(38, 49);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(38, 25);
            rGLabel.TabIndex = 60;
            rGLabel.Text = "RG:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.ForeColor = System.Drawing.Color.White;
            cPFLabel.Location = new System.Drawing.Point(35, 94);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(45, 25);
            cPFLabel.TabIndex = 61;
            cPFLabel.Text = "CPF:";
            // 
            // btCancelarColabEdit
            // 
            this.btCancelarColabEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btCancelarColabEdit.FlatAppearance.BorderSize = 0;
            this.btCancelarColabEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarColabEdit.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarColabEdit.ForeColor = System.Drawing.Color.White;
            this.btCancelarColabEdit.Location = new System.Drawing.Point(304, 578);
            this.btCancelarColabEdit.Name = "btCancelarColabEdit";
            this.btCancelarColabEdit.Size = new System.Drawing.Size(109, 44);
            this.btCancelarColabEdit.TabIndex = 73;
            this.btCancelarColabEdit.Text = "Cancelar";
            this.btCancelarColabEdit.UseVisualStyleBackColor = false;
            this.btCancelarColabEdit.Click += new System.EventHandler(this.btCancelarColabEdit_Click);
            // 
            // btDeletarColab
            // 
            this.btDeletarColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.btDeletarColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeletarColab.FlatAppearance.BorderSize = 0;
            this.btDeletarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletarColab.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarColab.ForeColor = System.Drawing.Color.White;
            this.btDeletarColab.Location = new System.Drawing.Point(439, 578);
            this.btDeletarColab.Name = "btDeletarColab";
            this.btDeletarColab.Size = new System.Drawing.Size(109, 44);
            this.btDeletarColab.TabIndex = 72;
            this.btDeletarColab.Text = "Deletar";
            this.btDeletarColab.UseVisualStyleBackColor = false;
            this.btDeletarColab.Click += new System.EventHandler(this.btDeleteColab_Click);
            // 
            // btSalvarColab
            // 
            this.btSalvarColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.btSalvarColab.FlatAppearance.BorderSize = 0;
            this.btSalvarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarColab.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarColab.ForeColor = System.Drawing.Color.White;
            this.btSalvarColab.Location = new System.Drawing.Point(571, 578);
            this.btSalvarColab.Name = "btSalvarColab";
            this.btSalvarColab.Size = new System.Drawing.Size(120, 44);
            this.btSalvarColab.TabIndex = 62;
            this.btSalvarColab.Text = "Salvar";
            this.btSalvarColab.UseVisualStyleBackColor = false;
            this.btSalvarColab.Click += new System.EventHandler(this.btSalvarColab_Click);
            // 
            // btProximoColab
            // 
            this.btProximoColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btProximoColab.FlatAppearance.BorderSize = 0;
            this.btProximoColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximoColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoColab.ForeColor = System.Drawing.Color.White;
            this.btProximoColab.Location = new System.Drawing.Point(266, 77);
            this.btProximoColab.Name = "btProximoColab";
            this.btProximoColab.Size = new System.Drawing.Size(38, 35);
            this.btProximoColab.TabIndex = 71;
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
            this.btAnteriorColab.Location = new System.Drawing.Point(29, 77);
            this.btAnteriorColab.Name = "btAnteriorColab";
            this.btAnteriorColab.Size = new System.Drawing.Size(38, 35);
            this.btAnteriorColab.TabIndex = 70;
            this.btAnteriorColab.Text = "<";
            this.btAnteriorColab.UseVisualStyleBackColor = false;
            this.btAnteriorColab.Click += new System.EventHandler(this.btAnteriorColab_Click);
            // 
            // btNovoColab
            // 
            this.btNovoColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btNovoColab.FlatAppearance.BorderSize = 0;
            this.btNovoColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoColab.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoColab.ForeColor = System.Drawing.Color.White;
            this.btNovoColab.Location = new System.Drawing.Point(171, 577);
            this.btNovoColab.Name = "btNovoColab";
            this.btNovoColab.Size = new System.Drawing.Size(120, 44);
            this.btNovoColab.TabIndex = 68;
            this.btNovoColab.Text = "Novo";
            this.btNovoColab.UseVisualStyleBackColor = false;
            this.btNovoColab.Click += new System.EventHandler(this.btNovoColab_Click);
            // 
            // tab_colaboradoresBindingSource
            // 
            this.tab_colaboradoresBindingSource.DataMember = "tab_colaboradores";
            this.tab_colaboradoresBindingSource.DataSource = this.bDMARCAFACILDataSet;
            // 
            // bDMARCAFACILDataSet
            // 
            this.bDMARCAFACILDataSet.DataSetName = "BDMARCAFACILDataSet";
            this.bDMARCAFACILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCadastroColaboradores
            // 
            this.lblCadastroColaboradores.AutoSize = true;
            this.lblCadastroColaboradores.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroColaboradores.ForeColor = System.Drawing.Color.White;
            this.lblCadastroColaboradores.Location = new System.Drawing.Point(77, 75);
            this.lblCadastroColaboradores.Name = "lblCadastroColaboradores";
            this.lblCadastroColaboradores.Size = new System.Drawing.Size(163, 38);
            this.lblCadastroColaboradores.TabIndex = 63;
            this.lblCadastroColaboradores.Text = "Colaborador";
            // 
            // btEditarColab
            // 
            this.btEditarColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btEditarColab.FlatAppearance.BorderSize = 0;
            this.btEditarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarColab.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarColab.ForeColor = System.Drawing.Color.White;
            this.btEditarColab.Location = new System.Drawing.Point(29, 578);
            this.btEditarColab.Name = "btEditarColab";
            this.btEditarColab.Size = new System.Drawing.Size(120, 44);
            this.btEditarColab.TabIndex = 75;
            this.btEditarColab.Text = "Editar";
            this.btEditarColab.UseVisualStyleBackColor = false;
            this.btEditarColab.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tab_colaboradoresTableAdapter
            // 
            this.tab_colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tab_agendamentoTableAdapter = null;
            this.tableAdapterManager.tab_avisosTableAdapter = null;
            this.tableAdapterManager.tab_colaboradoresTableAdapter = this.tab_colaboradoresTableAdapter;
            this.tableAdapterManager.tab_pacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MarcaFácil.BDMARCAFACILDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(500, 342);
            this.celularMaskedTextBox.Mask = "(00)00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.celularMaskedTextBox.TabIndex = 27;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(126, 342);
            this.telefoneMaskedTextBox.Mask = "(00)0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.telefoneMaskedTextBox.TabIndex = 25;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(126, 247);
            this.bairroTextBox.Multiline = true;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(200, 31);
            this.bairroTextBox.TabIndex = 13;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Endereço", true));
            this.endereçoTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereçoTextBox.Location = new System.Drawing.Point(126, 175);
            this.endereçoTextBox.Multiline = true;
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(680, 67);
            this.endereçoTextBox.TabIndex = 11;
            // 
            // data_de_NascimentoDateTimePicker
            // 
            this.data_de_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tab_colaboradoresBindingSource, "Data de Nascimento", true));
            this.data_de_NascimentoDateTimePicker.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_de_NascimentoDateTimePicker.Location = new System.Drawing.Point(500, 44);
            this.data_de_NascimentoDateTimePicker.Name = "data_de_NascimentoDateTimePicker";
            this.data_de_NascimentoDateTimePicker.Size = new System.Drawing.Size(305, 23);
            this.data_de_NascimentoDateTimePicker.TabIndex = 9;
            // 
            // nomeColaboradorTextBox
            // 
            this.nomeColaboradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "NomeColaborador", true));
            this.nomeColaboradorTextBox.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeColaboradorTextBox.Location = new System.Drawing.Point(126, 1);
            this.nomeColaboradorTextBox.Multiline = true;
            this.nomeColaboradorTextBox.Name = "nomeColaboradorTextBox";
            this.nomeColaboradorTextBox.Size = new System.Drawing.Size(511, 37);
            this.nomeColaboradorTextBox.TabIndex = 3;
            // 
            // idcolaboradorLabel1
            // 
            this.idcolaboradorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "idcolaborador", true));
            this.idcolaboradorLabel1.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcolaboradorLabel1.ForeColor = System.Drawing.Color.White;
            this.idcolaboradorLabel1.Location = new System.Drawing.Point(777, 1);
            this.idcolaboradorLabel1.Name = "idcolaboradorLabel1";
            this.idcolaboradorLabel1.Size = new System.Drawing.Size(200, 37);
            this.idcolaboradorLabel1.TabIndex = 1;
            this.idcolaboradorLabel1.Text = "label1";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "E-mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.Location = new System.Drawing.Point(126, 375);
            this.e_mailTextBox.Multiline = true;
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(200, 31);
            this.e_mailTextBox.TabIndex = 48;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.Location = new System.Drawing.Point(500, 131);
            this.cidadeTextBox.Multiline = true;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 31);
            this.cidadeTextBox.TabIndex = 38;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Estado", true));
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
            this.estadoComboBox.Location = new System.Drawing.Point(806, 129);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 33);
            this.estadoComboBox.TabIndex = 53;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Sexo", true));
            this.sexoComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(500, 80);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 33);
            this.sexoComboBox.TabIndex = 54;
            // 
            // estado_CivilComboBox
            // 
            this.estado_CivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Estado Civil", true));
            this.estado_CivilComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_CivilComboBox.FormattingEnabled = true;
            this.estado_CivilComboBox.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.estado_CivilComboBox.Location = new System.Drawing.Point(806, 80);
            this.estado_CivilComboBox.Name = "estado_CivilComboBox";
            this.estado_CivilComboBox.Size = new System.Drawing.Size(121, 33);
            this.estado_CivilComboBox.TabIndex = 55;
            // 
            // nomeConvênioComboBox
            // 
            this.nomeConvênioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "NomeConvênio", true));
            this.nomeConvênioComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeConvênioComboBox.FormattingEnabled = true;
            this.nomeConvênioComboBox.Items.AddRange(new object[] {
            "HAOC",
            "UNIMED",
            "SAMARITANO"});
            this.nomeConvênioComboBox.Location = new System.Drawing.Point(166, 129);
            this.nomeConvênioComboBox.Name = "nomeConvênioComboBox";
            this.nomeConvênioComboBox.Size = new System.Drawing.Size(121, 33);
            this.nomeConvênioComboBox.TabIndex = 56;
            // 
            // PainelColab
            // 
            this.PainelColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.PainelColab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelColab.Controls.Add(this.lblCRM);
            this.PainelColab.Controls.Add(this.labelEspecialidade);
            this.PainelColab.Controls.Add(cPFLabel);
            this.PainelColab.Controls.Add(this.cPFMaskedTextBox);
            this.PainelColab.Controls.Add(rGLabel);
            this.PainelColab.Controls.Add(this.rGMaskedTextBox);
            this.PainelColab.Controls.Add(this.cRMTextBox);
            this.PainelColab.Controls.Add(this.especialidadeComboBox);
            this.PainelColab.Controls.Add(cargoLabel);
            this.PainelColab.Controls.Add(this.cargoComboBox);
            this.PainelColab.Controls.Add(nomeConvênioLabel);
            this.PainelColab.Controls.Add(this.nomeConvênioComboBox);
            this.PainelColab.Controls.Add(estado_CivilLabel);
            this.PainelColab.Controls.Add(this.estado_CivilComboBox);
            this.PainelColab.Controls.Add(sexoLabel);
            this.PainelColab.Controls.Add(this.sexoComboBox);
            this.PainelColab.Controls.Add(estadoLabel);
            this.PainelColab.Controls.Add(this.estadoComboBox);
            this.PainelColab.Controls.Add(cidadeLabel);
            this.PainelColab.Controls.Add(this.cidadeTextBox);
            this.PainelColab.Controls.Add(e_mailLabel);
            this.PainelColab.Controls.Add(this.e_mailTextBox);
            this.PainelColab.Controls.Add(idcolaboradorLabel);
            this.PainelColab.Controls.Add(this.idcolaboradorLabel1);
            this.PainelColab.Controls.Add(nomeColaboradorLabel);
            this.PainelColab.Controls.Add(this.nomeColaboradorTextBox);
            this.PainelColab.Controls.Add(data_de_NascimentoLabel);
            this.PainelColab.Controls.Add(this.data_de_NascimentoDateTimePicker);
            this.PainelColab.Controls.Add(endereçoLabel);
            this.PainelColab.Controls.Add(this.endereçoTextBox);
            this.PainelColab.Controls.Add(bairroLabel);
            this.PainelColab.Controls.Add(this.bairroTextBox);
            this.PainelColab.Controls.Add(telefoneLabel);
            this.PainelColab.Controls.Add(this.telefoneMaskedTextBox);
            this.PainelColab.Controls.Add(celularLabel);
            this.PainelColab.Controls.Add(this.celularMaskedTextBox);
            this.PainelColab.Font = new System.Drawing.Font("Josefin Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PainelColab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PainelColab.Location = new System.Drawing.Point(13, 118);
            this.PainelColab.Name = "PainelColab";
            this.PainelColab.Size = new System.Drawing.Size(999, 428);
            this.PainelColab.TabIndex = 64;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.ForeColor = System.Drawing.Color.White;
            this.lblCRM.Location = new System.Drawing.Point(704, 300);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(52, 25);
            this.lblCRM.TabIndex = 64;
            this.lblCRM.Text = "CRM:";
            // 
            // labelEspecialidade
            // 
            this.labelEspecialidade.AutoSize = true;
            this.labelEspecialidade.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecialidade.ForeColor = System.Drawing.Color.White;
            this.labelEspecialidade.Location = new System.Drawing.Point(358, 297);
            this.labelEspecialidade.Name = "labelEspecialidade";
            this.labelEspecialidade.Size = new System.Drawing.Size(112, 25);
            this.labelEspecialidade.TabIndex = 63;
            this.labelEspecialidade.Text = "Especialidade:";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(146, 95);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(161, 23);
            this.cPFMaskedTextBox.TabIndex = 62;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "RG", true));
            this.rGMaskedTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(146, 50);
            this.rGMaskedTextBox.Mask = "00.000.000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(161, 23);
            this.rGMaskedTextBox.TabIndex = 61;
            // 
            // cRMTextBox
            // 
            this.cRMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "CRM", true));
            this.cRMTextBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRMTextBox.Location = new System.Drawing.Point(806, 293);
            this.cRMTextBox.Multiline = true;
            this.cRMTextBox.Name = "cRMTextBox";
            this.cRMTextBox.Size = new System.Drawing.Size(100, 33);
            this.cRMTextBox.TabIndex = 59;
            // 
            // especialidadeComboBox
            // 
            this.especialidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Especialidade", true));
            this.especialidadeComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidadeComboBox.FormattingEnabled = true;
            this.especialidadeComboBox.Location = new System.Drawing.Point(500, 293);
            this.especialidadeComboBox.Name = "especialidadeComboBox";
            this.especialidadeComboBox.Size = new System.Drawing.Size(121, 33);
            this.especialidadeComboBox.TabIndex = 58;
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_colaboradoresBindingSource, "Cargo", true));
            this.cargoComboBox.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Items.AddRange(new object[] {
            "Recepcionista",
            "Médico",
            "Auxiliar Administrativo",
            "Técnico de Limpeza",
            "Terceirizado"});
            this.cargoComboBox.Location = new System.Drawing.Point(166, 293);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(121, 33);
            this.cargoComboBox.TabIndex = 57;
            this.cargoComboBox.SelectedIndexChanged += new System.EventHandler(this.cargoComboBox_SelectedIndexChanged);
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btEditarColab);
            this.Controls.Add(this.btCancelarColabEdit);
            this.Controls.Add(this.btDeletarColab);
            this.Controls.Add(this.btSalvarColab);
            this.Controls.Add(this.btProximoColab);
            this.Controls.Add(this.btAnteriorColab);
            this.Controls.Add(this.btNovoColab);
            this.Controls.Add(this.PainelColab);
            this.Controls.Add(this.lblCadastroColaboradores);
            this.Name = "Colaboradores";
            this.Size = new System.Drawing.Size(1028, 653);
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMARCAFACILDataSet)).EndInit();
            this.PainelColab.ResumeLayout(false);
            this.PainelColab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarColabEdit;
        private System.Windows.Forms.Button btDeletarColab;
        private System.Windows.Forms.Button btSalvarColab;
        private System.Windows.Forms.Button btProximoColab;
        private System.Windows.Forms.Button btAnteriorColab;
        private System.Windows.Forms.Button btNovoColab;
        private System.Windows.Forms.Label lblCadastroColaboradores;
        private System.Windows.Forms.Button btEditarColab;
        private BDMARCAFACILDataSet bDMARCAFACILDataSet;
        private System.Windows.Forms.BindingSource tab_colaboradoresBindingSource;
        private BDMARCAFACILDataSetTableAdapters.tab_colaboradoresTableAdapter tab_colaboradoresTableAdapter;
        private BDMARCAFACILDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.DateTimePicker data_de_NascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeColaboradorTextBox;
        private System.Windows.Forms.Label idcolaboradorLabel1;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox estado_CivilComboBox;
        private System.Windows.Forms.ComboBox nomeConvênioComboBox;
        private System.Windows.Forms.Panel PainelColab;
        private System.Windows.Forms.ComboBox especialidadeComboBox;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.TextBox cRMTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.Label labelEspecialidade;
        private System.Windows.Forms.Label lblCRM;
    }
}
