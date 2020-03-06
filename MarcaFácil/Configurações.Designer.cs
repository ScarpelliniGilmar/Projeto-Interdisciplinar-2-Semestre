namespace MarcaFácil
{
    partial class Configurações
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
            System.Windows.Forms.Label nomeColaboradorLabel;
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.btSalvarPermissão = new System.Windows.Forms.Button();
            this.painelDesignBtConfig = new System.Windows.Forms.Panel();
            this.btEditarPermissão = new System.Windows.Forms.Button();
            this.painelPermissões = new System.Windows.Forms.Panel();
            this.checkDeletarConvênios = new System.Windows.Forms.CheckBox();
            this.checkDeletarColab = new System.Windows.Forms.CheckBox();
            this.checkDeletarAgendamentos = new System.Windows.Forms.CheckBox();
            this.checkDeletarPacientes = new System.Windows.Forms.CheckBox();
            this.checkModificarConfig = new System.Windows.Forms.CheckBox();
            this.checkModificarConvênios = new System.Windows.Forms.CheckBox();
            this.checkModificarColab = new System.Windows.Forms.CheckBox();
            this.checkModificarAgendamentos = new System.Windows.Forms.CheckBox();
            this.checkModificarPacientes = new System.Windows.Forms.CheckBox();
            this.checkCriarConvênios = new System.Windows.Forms.CheckBox();
            this.checkCriarColaboradores = new System.Windows.Forms.CheckBox();
            this.checkCriarAgendamentos = new System.Windows.Forms.CheckBox();
            this.checkCriarPacientes = new System.Windows.Forms.CheckBox();
            this.checkLerConfigurações = new System.Windows.Forms.CheckBox();
            this.checkLerConvênios = new System.Windows.Forms.CheckBox();
            this.checkLerColaboradores = new System.Windows.Forms.CheckBox();
            this.checkLerAgendamentos = new System.Windows.Forms.CheckBox();
            this.checkLerPacientes = new System.Windows.Forms.CheckBox();
            this.checkDeletarInício = new System.Windows.Forms.CheckBox();
            this.checkModificarInício = new System.Windows.Forms.CheckBox();
            this.checkCriarInício = new System.Windows.Forms.CheckBox();
            this.checkLerInicio = new System.Windows.Forms.CheckBox();
            this.lblConfiguraçõesTitle = new System.Windows.Forms.Label();
            this.lblConvêniosTitle = new System.Windows.Forms.Label();
            this.lblColaboradoresTitle = new System.Windows.Forms.Label();
            this.lblAgendamentosTitle = new System.Windows.Forms.Label();
            this.lblPacientesTitle = new System.Windows.Forms.Label();
            this.lblInicioTitle = new System.Windows.Forms.Label();
            this.nomeColaboradorLabel1 = new System.Windows.Forms.Label();
            this.lblPermissões = new System.Windows.Forms.Label();
            this.lblUsuários = new System.Windows.Forms.Label();
            this.btCancelarColabEdit = new System.Windows.Forms.Button();
            nomeColaboradorLabel = new System.Windows.Forms.Label();
            this.painelPermissões.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeColaboradorLabel
            // 
            nomeColaboradorLabel.AutoSize = true;
            nomeColaboradorLabel.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeColaboradorLabel.Location = new System.Drawing.Point(3, 0);
            nomeColaboradorLabel.Name = "nomeColaboradorLabel";
            nomeColaboradorLabel.Size = new System.Drawing.Size(70, 30);
            nomeColaboradorLabel.TabIndex = 0;
            nomeColaboradorLabel.Text = "Nome:";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Font = new System.Drawing.Font("Josefin Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(43, 83);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(455, 41);
            this.comboBoxUsers.TabIndex = 77;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // btSalvarPermissão
            // 
            this.btSalvarPermissão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(188)))), ((int)(((byte)(149)))));
            this.btSalvarPermissão.FlatAppearance.BorderSize = 0;
            this.btSalvarPermissão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarPermissão.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarPermissão.ForeColor = System.Drawing.Color.White;
            this.btSalvarPermissão.Location = new System.Drawing.Point(723, 535);
            this.btSalvarPermissão.Name = "btSalvarPermissão";
            this.btSalvarPermissão.Size = new System.Drawing.Size(120, 44);
            this.btSalvarPermissão.TabIndex = 71;
            this.btSalvarPermissão.Text = "Salvar";
            this.btSalvarPermissão.UseVisualStyleBackColor = false;
            this.btSalvarPermissão.Click += new System.EventHandler(this.btSalvarPermissão_Click);
            // 
            // painelDesignBtConfig
            // 
            this.painelDesignBtConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.painelDesignBtConfig.Location = new System.Drawing.Point(861, 535);
            this.painelDesignBtConfig.Name = "painelDesignBtConfig";
            this.painelDesignBtConfig.Size = new System.Drawing.Size(10, 44);
            this.painelDesignBtConfig.TabIndex = 76;
            // 
            // btEditarPermissão
            // 
            this.btEditarPermissão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btEditarPermissão.FlatAppearance.BorderSize = 0;
            this.btEditarPermissão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarPermissão.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarPermissão.ForeColor = System.Drawing.Color.White;
            this.btEditarPermissão.Location = new System.Drawing.Point(869, 535);
            this.btEditarPermissão.Name = "btEditarPermissão";
            this.btEditarPermissão.Size = new System.Drawing.Size(112, 44);
            this.btEditarPermissão.TabIndex = 75;
            this.btEditarPermissão.Text = "Editar";
            this.btEditarPermissão.UseVisualStyleBackColor = false;
            this.btEditarPermissão.Click += new System.EventHandler(this.btEditarPermissão_Click);
            // 
            // painelPermissões
            // 
            this.painelPermissões.BackColor = System.Drawing.Color.White;
            this.painelPermissões.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelPermissões.Controls.Add(this.checkDeletarConvênios);
            this.painelPermissões.Controls.Add(this.checkDeletarColab);
            this.painelPermissões.Controls.Add(this.checkDeletarAgendamentos);
            this.painelPermissões.Controls.Add(this.checkDeletarPacientes);
            this.painelPermissões.Controls.Add(this.checkModificarConfig);
            this.painelPermissões.Controls.Add(this.checkModificarConvênios);
            this.painelPermissões.Controls.Add(this.checkModificarColab);
            this.painelPermissões.Controls.Add(this.checkModificarAgendamentos);
            this.painelPermissões.Controls.Add(this.checkModificarPacientes);
            this.painelPermissões.Controls.Add(this.checkCriarConvênios);
            this.painelPermissões.Controls.Add(this.checkCriarColaboradores);
            this.painelPermissões.Controls.Add(this.checkCriarAgendamentos);
            this.painelPermissões.Controls.Add(this.checkCriarPacientes);
            this.painelPermissões.Controls.Add(this.checkLerConfigurações);
            this.painelPermissões.Controls.Add(this.checkLerConvênios);
            this.painelPermissões.Controls.Add(this.checkLerColaboradores);
            this.painelPermissões.Controls.Add(this.checkLerAgendamentos);
            this.painelPermissões.Controls.Add(this.checkLerPacientes);
            this.painelPermissões.Controls.Add(this.checkDeletarInício);
            this.painelPermissões.Controls.Add(this.checkModificarInício);
            this.painelPermissões.Controls.Add(this.checkCriarInício);
            this.painelPermissões.Controls.Add(this.checkLerInicio);
            this.painelPermissões.Controls.Add(this.lblConfiguraçõesTitle);
            this.painelPermissões.Controls.Add(this.lblConvêniosTitle);
            this.painelPermissões.Controls.Add(this.lblColaboradoresTitle);
            this.painelPermissões.Controls.Add(this.lblAgendamentosTitle);
            this.painelPermissões.Controls.Add(this.lblPacientesTitle);
            this.painelPermissões.Controls.Add(this.lblInicioTitle);
            this.painelPermissões.Controls.Add(nomeColaboradorLabel);
            this.painelPermissões.Controls.Add(this.nomeColaboradorLabel1);
            this.painelPermissões.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelPermissões.Location = new System.Drawing.Point(43, 263);
            this.painelPermissões.Name = "painelPermissões";
            this.painelPermissões.Size = new System.Drawing.Size(938, 225);
            this.painelPermissões.TabIndex = 72;
            // 
            // checkDeletarConvênios
            // 
            this.checkDeletarConvênios.AutoSize = true;
            this.checkDeletarConvênios.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeletarConvênios.Location = new System.Drawing.Point(717, 155);
            this.checkDeletarConvênios.Name = "checkDeletarConvênios";
            this.checkDeletarConvênios.Size = new System.Drawing.Size(81, 28);
            this.checkDeletarConvênios.TabIndex = 59;
            this.checkDeletarConvênios.Text = "Deletar";
            this.checkDeletarConvênios.UseVisualStyleBackColor = true;
            // 
            // checkDeletarColab
            // 
            this.checkDeletarColab.AutoSize = true;
            this.checkDeletarColab.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeletarColab.Location = new System.Drawing.Point(717, 127);
            this.checkDeletarColab.Name = "checkDeletarColab";
            this.checkDeletarColab.Size = new System.Drawing.Size(81, 28);
            this.checkDeletarColab.TabIndex = 58;
            this.checkDeletarColab.Text = "Deletar";
            this.checkDeletarColab.UseVisualStyleBackColor = true;
            // 
            // checkDeletarAgendamentos
            // 
            this.checkDeletarAgendamentos.AutoSize = true;
            this.checkDeletarAgendamentos.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeletarAgendamentos.Location = new System.Drawing.Point(717, 97);
            this.checkDeletarAgendamentos.Name = "checkDeletarAgendamentos";
            this.checkDeletarAgendamentos.Size = new System.Drawing.Size(81, 28);
            this.checkDeletarAgendamentos.TabIndex = 57;
            this.checkDeletarAgendamentos.Text = "Deletar";
            this.checkDeletarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // checkDeletarPacientes
            // 
            this.checkDeletarPacientes.AutoSize = true;
            this.checkDeletarPacientes.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeletarPacientes.Location = new System.Drawing.Point(717, 68);
            this.checkDeletarPacientes.Name = "checkDeletarPacientes";
            this.checkDeletarPacientes.Size = new System.Drawing.Size(81, 28);
            this.checkDeletarPacientes.TabIndex = 56;
            this.checkDeletarPacientes.Text = "Deletar";
            this.checkDeletarPacientes.UseVisualStyleBackColor = true;
            // 
            // checkModificarConfig
            // 
            this.checkModificarConfig.AutoSize = true;
            this.checkModificarConfig.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarConfig.Location = new System.Drawing.Point(596, 189);
            this.checkModificarConfig.Name = "checkModificarConfig";
            this.checkModificarConfig.Size = new System.Drawing.Size(95, 28);
            this.checkModificarConfig.TabIndex = 55;
            this.checkModificarConfig.Text = "Modificar";
            this.checkModificarConfig.UseVisualStyleBackColor = true;
            // 
            // checkModificarConvênios
            // 
            this.checkModificarConvênios.AutoSize = true;
            this.checkModificarConvênios.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarConvênios.Location = new System.Drawing.Point(596, 155);
            this.checkModificarConvênios.Name = "checkModificarConvênios";
            this.checkModificarConvênios.Size = new System.Drawing.Size(95, 28);
            this.checkModificarConvênios.TabIndex = 54;
            this.checkModificarConvênios.Text = "Modificar";
            this.checkModificarConvênios.UseVisualStyleBackColor = true;
            // 
            // checkModificarColab
            // 
            this.checkModificarColab.AutoSize = true;
            this.checkModificarColab.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarColab.Location = new System.Drawing.Point(596, 127);
            this.checkModificarColab.Name = "checkModificarColab";
            this.checkModificarColab.Size = new System.Drawing.Size(95, 28);
            this.checkModificarColab.TabIndex = 53;
            this.checkModificarColab.Text = "Modificar";
            this.checkModificarColab.UseVisualStyleBackColor = true;
            // 
            // checkModificarAgendamentos
            // 
            this.checkModificarAgendamentos.AutoSize = true;
            this.checkModificarAgendamentos.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarAgendamentos.Location = new System.Drawing.Point(596, 97);
            this.checkModificarAgendamentos.Name = "checkModificarAgendamentos";
            this.checkModificarAgendamentos.Size = new System.Drawing.Size(95, 28);
            this.checkModificarAgendamentos.TabIndex = 52;
            this.checkModificarAgendamentos.Text = "Modificar";
            this.checkModificarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // checkModificarPacientes
            // 
            this.checkModificarPacientes.AutoSize = true;
            this.checkModificarPacientes.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarPacientes.Location = new System.Drawing.Point(596, 68);
            this.checkModificarPacientes.Name = "checkModificarPacientes";
            this.checkModificarPacientes.Size = new System.Drawing.Size(95, 28);
            this.checkModificarPacientes.TabIndex = 51;
            this.checkModificarPacientes.Text = "Modificar";
            this.checkModificarPacientes.UseVisualStyleBackColor = true;
            // 
            // checkCriarConvênios
            // 
            this.checkCriarConvênios.AutoSize = true;
            this.checkCriarConvênios.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCriarConvênios.Location = new System.Drawing.Point(478, 155);
            this.checkCriarConvênios.Name = "checkCriarConvênios";
            this.checkCriarConvênios.Size = new System.Drawing.Size(64, 28);
            this.checkCriarConvênios.TabIndex = 49;
            this.checkCriarConvênios.Text = "Criar";
            this.checkCriarConvênios.UseVisualStyleBackColor = true;
            // 
            // checkCriarColaboradores
            // 
            this.checkCriarColaboradores.AutoSize = true;
            this.checkCriarColaboradores.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCriarColaboradores.Location = new System.Drawing.Point(478, 127);
            this.checkCriarColaboradores.Name = "checkCriarColaboradores";
            this.checkCriarColaboradores.Size = new System.Drawing.Size(64, 28);
            this.checkCriarColaboradores.TabIndex = 48;
            this.checkCriarColaboradores.Text = "Criar";
            this.checkCriarColaboradores.UseVisualStyleBackColor = true;
            // 
            // checkCriarAgendamentos
            // 
            this.checkCriarAgendamentos.AutoSize = true;
            this.checkCriarAgendamentos.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCriarAgendamentos.Location = new System.Drawing.Point(478, 97);
            this.checkCriarAgendamentos.Name = "checkCriarAgendamentos";
            this.checkCriarAgendamentos.Size = new System.Drawing.Size(64, 28);
            this.checkCriarAgendamentos.TabIndex = 47;
            this.checkCriarAgendamentos.Text = "Criar";
            this.checkCriarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // checkCriarPacientes
            // 
            this.checkCriarPacientes.AutoSize = true;
            this.checkCriarPacientes.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCriarPacientes.Location = new System.Drawing.Point(478, 68);
            this.checkCriarPacientes.Name = "checkCriarPacientes";
            this.checkCriarPacientes.Size = new System.Drawing.Size(64, 28);
            this.checkCriarPacientes.TabIndex = 46;
            this.checkCriarPacientes.Text = "Criar";
            this.checkCriarPacientes.UseVisualStyleBackColor = true;
            // 
            // checkLerConfigurações
            // 
            this.checkLerConfigurações.AutoSize = true;
            this.checkLerConfigurações.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerConfigurações.Location = new System.Drawing.Point(331, 189);
            this.checkLerConfigurações.Name = "checkLerConfigurações";
            this.checkLerConfigurações.Size = new System.Drawing.Size(52, 28);
            this.checkLerConfigurações.TabIndex = 45;
            this.checkLerConfigurações.Text = "Ler";
            this.checkLerConfigurações.UseVisualStyleBackColor = true;
            // 
            // checkLerConvênios
            // 
            this.checkLerConvênios.AutoSize = true;
            this.checkLerConvênios.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerConvênios.Location = new System.Drawing.Point(331, 155);
            this.checkLerConvênios.Name = "checkLerConvênios";
            this.checkLerConvênios.Size = new System.Drawing.Size(52, 28);
            this.checkLerConvênios.TabIndex = 44;
            this.checkLerConvênios.Text = "Ler";
            this.checkLerConvênios.UseVisualStyleBackColor = true;
            // 
            // checkLerColaboradores
            // 
            this.checkLerColaboradores.AutoSize = true;
            this.checkLerColaboradores.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerColaboradores.Location = new System.Drawing.Point(331, 127);
            this.checkLerColaboradores.Name = "checkLerColaboradores";
            this.checkLerColaboradores.Size = new System.Drawing.Size(52, 28);
            this.checkLerColaboradores.TabIndex = 43;
            this.checkLerColaboradores.Text = "Ler";
            this.checkLerColaboradores.UseVisualStyleBackColor = true;
            // 
            // checkLerAgendamentos
            // 
            this.checkLerAgendamentos.AutoSize = true;
            this.checkLerAgendamentos.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerAgendamentos.Location = new System.Drawing.Point(331, 97);
            this.checkLerAgendamentos.Name = "checkLerAgendamentos";
            this.checkLerAgendamentos.Size = new System.Drawing.Size(52, 28);
            this.checkLerAgendamentos.TabIndex = 42;
            this.checkLerAgendamentos.Text = "Ler";
            this.checkLerAgendamentos.UseVisualStyleBackColor = true;
            // 
            // checkLerPacientes
            // 
            this.checkLerPacientes.AutoSize = true;
            this.checkLerPacientes.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerPacientes.Location = new System.Drawing.Point(331, 68);
            this.checkLerPacientes.Name = "checkLerPacientes";
            this.checkLerPacientes.Size = new System.Drawing.Size(52, 28);
            this.checkLerPacientes.TabIndex = 41;
            this.checkLerPacientes.Text = "Ler";
            this.checkLerPacientes.UseVisualStyleBackColor = true;
            // 
            // checkDeletarInício
            // 
            this.checkDeletarInício.AutoSize = true;
            this.checkDeletarInício.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeletarInício.Location = new System.Drawing.Point(717, 36);
            this.checkDeletarInício.Name = "checkDeletarInício";
            this.checkDeletarInício.Size = new System.Drawing.Size(81, 28);
            this.checkDeletarInício.TabIndex = 40;
            this.checkDeletarInício.Text = "Deletar";
            this.checkDeletarInício.UseVisualStyleBackColor = true;
            // 
            // checkModificarInício
            // 
            this.checkModificarInício.AutoSize = true;
            this.checkModificarInício.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModificarInício.Location = new System.Drawing.Point(596, 36);
            this.checkModificarInício.Name = "checkModificarInício";
            this.checkModificarInício.Size = new System.Drawing.Size(95, 28);
            this.checkModificarInício.TabIndex = 39;
            this.checkModificarInício.Text = "Modificar";
            this.checkModificarInício.UseVisualStyleBackColor = true;
            // 
            // checkCriarInício
            // 
            this.checkCriarInício.AutoSize = true;
            this.checkCriarInício.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCriarInício.Location = new System.Drawing.Point(478, 36);
            this.checkCriarInício.Name = "checkCriarInício";
            this.checkCriarInício.Size = new System.Drawing.Size(64, 28);
            this.checkCriarInício.TabIndex = 38;
            this.checkCriarInício.Text = "Criar";
            this.checkCriarInício.UseVisualStyleBackColor = true;
            // 
            // checkLerInicio
            // 
            this.checkLerInicio.AutoSize = true;
            this.checkLerInicio.Font = new System.Drawing.Font("Josefin Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLerInicio.Location = new System.Drawing.Point(331, 36);
            this.checkLerInicio.Name = "checkLerInicio";
            this.checkLerInicio.Size = new System.Drawing.Size(52, 28);
            this.checkLerInicio.TabIndex = 37;
            this.checkLerInicio.Text = "Ler";
            this.checkLerInicio.UseVisualStyleBackColor = true;
            // 
            // lblConfiguraçõesTitle
            // 
            this.lblConfiguraçõesTitle.AutoSize = true;
            this.lblConfiguraçõesTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguraçõesTitle.Location = new System.Drawing.Point(7, 191);
            this.lblConfiguraçõesTitle.Name = "lblConfiguraçõesTitle";
            this.lblConfiguraçõesTitle.Size = new System.Drawing.Size(121, 25);
            this.lblConfiguraçõesTitle.TabIndex = 7;
            this.lblConfiguraçõesTitle.Text = "Configurações";
            // 
            // lblConvêniosTitle
            // 
            this.lblConvêniosTitle.AutoSize = true;
            this.lblConvêniosTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvêniosTitle.Location = new System.Drawing.Point(10, 157);
            this.lblConvêniosTitle.Name = "lblConvêniosTitle";
            this.lblConvêniosTitle.Size = new System.Drawing.Size(91, 25);
            this.lblConvêniosTitle.TabIndex = 6;
            this.lblConvêniosTitle.Text = "Convênios";
            // 
            // lblColaboradoresTitle
            // 
            this.lblColaboradoresTitle.AutoSize = true;
            this.lblColaboradoresTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaboradoresTitle.Location = new System.Drawing.Point(8, 129);
            this.lblColaboradoresTitle.Name = "lblColaboradoresTitle";
            this.lblColaboradoresTitle.Size = new System.Drawing.Size(125, 25);
            this.lblColaboradoresTitle.TabIndex = 5;
            this.lblColaboradoresTitle.Text = "Colaboradores";
            // 
            // lblAgendamentosTitle
            // 
            this.lblAgendamentosTitle.AutoSize = true;
            this.lblAgendamentosTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamentosTitle.Location = new System.Drawing.Point(7, 99);
            this.lblAgendamentosTitle.Name = "lblAgendamentosTitle";
            this.lblAgendamentosTitle.Size = new System.Drawing.Size(127, 25);
            this.lblAgendamentosTitle.TabIndex = 4;
            this.lblAgendamentosTitle.Text = "Agendamentos";
            // 
            // lblPacientesTitle
            // 
            this.lblPacientesTitle.AutoSize = true;
            this.lblPacientesTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientesTitle.Location = new System.Drawing.Point(7, 70);
            this.lblPacientesTitle.Name = "lblPacientesTitle";
            this.lblPacientesTitle.Size = new System.Drawing.Size(86, 25);
            this.lblPacientesTitle.TabIndex = 3;
            this.lblPacientesTitle.Text = "Pacientes";
            // 
            // lblInicioTitle
            // 
            this.lblInicioTitle.AutoSize = true;
            this.lblInicioTitle.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioTitle.Location = new System.Drawing.Point(7, 38);
            this.lblInicioTitle.Name = "lblInicioTitle";
            this.lblInicioTitle.Size = new System.Drawing.Size(54, 25);
            this.lblInicioTitle.TabIndex = 2;
            this.lblInicioTitle.Text = "Início";
            // 
            // nomeColaboradorLabel1
            // 
            this.nomeColaboradorLabel1.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeColaboradorLabel1.Location = new System.Drawing.Point(107, 0);
            this.nomeColaboradorLabel1.Name = "nomeColaboradorLabel1";
            this.nomeColaboradorLabel1.Size = new System.Drawing.Size(100, 33);
            this.nomeColaboradorLabel1.TabIndex = 1;
            this.nomeColaboradorLabel1.Text = "-";
            // 
            // lblPermissões
            // 
            this.lblPermissões.AutoSize = true;
            this.lblPermissões.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissões.ForeColor = System.Drawing.Color.White;
            this.lblPermissões.Location = new System.Drawing.Point(38, 222);
            this.lblPermissões.Name = "lblPermissões";
            this.lblPermissões.Size = new System.Drawing.Size(143, 38);
            this.lblPermissões.TabIndex = 70;
            this.lblPermissões.Text = "Permissões";
            // 
            // lblUsuários
            // 
            this.lblUsuários.AutoSize = true;
            this.lblUsuários.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuários.ForeColor = System.Drawing.Color.White;
            this.lblUsuários.Location = new System.Drawing.Point(39, 42);
            this.lblUsuários.Name = "lblUsuários";
            this.lblUsuários.Size = new System.Drawing.Size(106, 38);
            this.lblUsuários.TabIndex = 69;
            this.lblUsuários.Text = "Usuário";
            // 
            // btCancelarColabEdit
            // 
            this.btCancelarColabEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btCancelarColabEdit.FlatAppearance.BorderSize = 0;
            this.btCancelarColabEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarColabEdit.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarColabEdit.ForeColor = System.Drawing.Color.White;
            this.btCancelarColabEdit.Location = new System.Drawing.Point(871, 585);
            this.btCancelarColabEdit.Name = "btCancelarColabEdit";
            this.btCancelarColabEdit.Size = new System.Drawing.Size(109, 44);
            this.btCancelarColabEdit.TabIndex = 78;
            this.btCancelarColabEdit.Text = "Cancelar";
            this.btCancelarColabEdit.UseVisualStyleBackColor = false;
            this.btCancelarColabEdit.Click += new System.EventHandler(this.btCancelarColabEdit_Click);
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btCancelarColabEdit);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.btSalvarPermissão);
            this.Controls.Add(this.painelDesignBtConfig);
            this.Controls.Add(this.btEditarPermissão);
            this.Controls.Add(this.painelPermissões);
            this.Controls.Add(this.lblPermissões);
            this.Controls.Add(this.lblUsuários);
            this.Name = "Configurações";
            this.Size = new System.Drawing.Size(1019, 653);
            this.Load += new System.EventHandler(this.Configurações_Load);
            this.painelPermissões.ResumeLayout(false);
            this.painelPermissões.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button btSalvarPermissão;
        private System.Windows.Forms.Panel painelDesignBtConfig;
        private System.Windows.Forms.Button btEditarPermissão;
        private System.Windows.Forms.Panel painelPermissões;
        private System.Windows.Forms.CheckBox checkDeletarConvênios;
        private System.Windows.Forms.CheckBox checkDeletarColab;
        private System.Windows.Forms.CheckBox checkDeletarAgendamentos;
        private System.Windows.Forms.CheckBox checkDeletarPacientes;
        private System.Windows.Forms.CheckBox checkModificarConfig;
        private System.Windows.Forms.CheckBox checkModificarConvênios;
        private System.Windows.Forms.CheckBox checkModificarColab;
        private System.Windows.Forms.CheckBox checkModificarAgendamentos;
        private System.Windows.Forms.CheckBox checkModificarPacientes;
        private System.Windows.Forms.CheckBox checkCriarConvênios;
        private System.Windows.Forms.CheckBox checkCriarColaboradores;
        private System.Windows.Forms.CheckBox checkCriarAgendamentos;
        private System.Windows.Forms.CheckBox checkCriarPacientes;
        private System.Windows.Forms.CheckBox checkLerConfigurações;
        private System.Windows.Forms.CheckBox checkLerConvênios;
        private System.Windows.Forms.CheckBox checkLerColaboradores;
        private System.Windows.Forms.CheckBox checkLerAgendamentos;
        private System.Windows.Forms.CheckBox checkLerPacientes;
        private System.Windows.Forms.CheckBox checkDeletarInício;
        private System.Windows.Forms.CheckBox checkModificarInício;
        private System.Windows.Forms.CheckBox checkCriarInício;
        private System.Windows.Forms.CheckBox checkLerInicio;
        private System.Windows.Forms.Label lblConfiguraçõesTitle;
        private System.Windows.Forms.Label lblConvêniosTitle;
        private System.Windows.Forms.Label lblColaboradoresTitle;
        private System.Windows.Forms.Label lblAgendamentosTitle;
        private System.Windows.Forms.Label lblPacientesTitle;
        private System.Windows.Forms.Label lblInicioTitle;
        private System.Windows.Forms.Label nomeColaboradorLabel1;
        private System.Windows.Forms.Label lblPermissões;
        private System.Windows.Forms.Label lblUsuários;
        private System.Windows.Forms.Button btCancelarColabEdit;
    }
}
