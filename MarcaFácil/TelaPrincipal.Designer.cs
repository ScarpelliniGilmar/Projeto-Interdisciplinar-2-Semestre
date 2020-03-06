namespace MarcaFácil
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.ucInício1 = new MarcaFácil.ucInício();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserPicture = new MarcaFácil.PictureBoxRedonda();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btConfigurações = new System.Windows.Forms.Button();
            this.btAjuda = new System.Windows.Forms.Button();
            this.btAgendamentos = new System.Windows.Forms.Button();
            this.btColaboradores = new System.Windows.Forms.Button();
            this.btInício = new System.Windows.Forms.Button();
            this.btPacientes = new System.Windows.Forms.Button();
            this.pBtLateral = new System.Windows.Forms.Panel();
            this.painelLogoHome = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.lblFaculdadeEGrupo = new System.Windows.Forms.Label();
            this.painelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.painelLogoHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.ucInício1);
            this.painelPrincipal.Location = new System.Drawing.Point(243, 44);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1019, 642);
            this.painelPrincipal.TabIndex = 18;
            // 
            // ucInício1
            // 
            this.ucInício1.Location = new System.Drawing.Point(0, 0);
            this.ucInício1.Name = "ucInício1";
            this.ucInício1.Size = new System.Drawing.Size(1016, 639);
            this.ucInício1.TabIndex = 0;
            // 
            // btMinimizar
            // 
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btMinimizar.ForeColor = System.Drawing.Color.White;
            this.btMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMinimizar.Location = new System.Drawing.Point(1187, -6);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(26, 31);
            this.btMinimizar.TabIndex = 17;
            this.btMinimizar.Text = "_";
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btMaximizar.ForeColor = System.Drawing.Color.White;
            this.btMaximizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMaximizar.Location = new System.Drawing.Point(1219, -5);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(26, 31);
            this.btMaximizar.TabIndex = 16;
            this.btMaximizar.Text = "□";
            this.btMaximizar.UseVisualStyleBackColor = true;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFechar.Location = new System.Drawing.Point(1245, -5);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(26, 31);
            this.btFechar.TabIndex = 15;
            this.btFechar.Text = "x";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblData.Location = new System.Drawing.Point(647, 5);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(162, 25);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "[Data e hora atual]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.UserPicture);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btConfigurações);
            this.panel1.Controls.Add(this.btAjuda);
            this.panel1.Controls.Add(this.btAgendamentos);
            this.panel1.Controls.Add(this.btColaboradores);
            this.panel1.Controls.Add(this.btInício);
            this.panel1.Controls.Add(this.btPacientes);
            this.panel1.Controls.Add(this.pBtLateral);
            this.panel1.Controls.Add(this.painelLogoHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 719);
            this.panel1.TabIndex = 13;
            // 
            // UserPicture
            // 
            this.UserPicture.BackColor = System.Drawing.Color.Transparent;
            this.UserPicture.Location = new System.Drawing.Point(6, 117);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(87, 73);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 16;
            this.UserPicture.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(99, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 25);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "label1";
            // 
            // btConfigurações
            // 
            this.btConfigurações.FlatAppearance.BorderSize = 0;
            this.btConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfigurações.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btConfigurações.ForeColor = System.Drawing.Color.White;
            this.btConfigurações.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btConfigurações.Location = new System.Drawing.Point(6, 478);
            this.btConfigurações.Name = "btConfigurações";
            this.btConfigurações.Size = new System.Drawing.Size(231, 48);
            this.btConfigurações.TabIndex = 13;
            this.btConfigurações.Text = "Configurações";
            this.btConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfigurações.UseVisualStyleBackColor = true;
            this.btConfigurações.Click += new System.EventHandler(this.btConfigurações_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.FlatAppearance.BorderSize = 0;
            this.btAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjuda.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btAjuda.ForeColor = System.Drawing.Color.White;
            this.btAjuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAjuda.Location = new System.Drawing.Point(6, 425);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(231, 48);
            this.btAjuda.TabIndex = 11;
            this.btAjuda.Text = "Ajuda";
            this.btAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjuda.UseVisualStyleBackColor = true;
            this.btAjuda.Click += new System.EventHandler(this.btAjuda_Click);
            // 
            // btAgendamentos
            // 
            this.btAgendamentos.FlatAppearance.BorderSize = 0;
            this.btAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendamentos.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btAgendamentos.ForeColor = System.Drawing.Color.White;
            this.btAgendamentos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAgendamentos.Location = new System.Drawing.Point(9, 317);
            this.btAgendamentos.Name = "btAgendamentos";
            this.btAgendamentos.Size = new System.Drawing.Size(231, 48);
            this.btAgendamentos.TabIndex = 5;
            this.btAgendamentos.Text = "Agendamentos";
            this.btAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgendamentos.UseVisualStyleBackColor = true;
            this.btAgendamentos.Click += new System.EventHandler(this.btAgendamentos_Click);
            // 
            // btColaboradores
            // 
            this.btColaboradores.FlatAppearance.BorderSize = 0;
            this.btColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColaboradores.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btColaboradores.ForeColor = System.Drawing.Color.White;
            this.btColaboradores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btColaboradores.Location = new System.Drawing.Point(9, 371);
            this.btColaboradores.Name = "btColaboradores";
            this.btColaboradores.Size = new System.Drawing.Size(231, 48);
            this.btColaboradores.TabIndex = 7;
            this.btColaboradores.Text = "Colaboradores";
            this.btColaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btColaboradores.UseVisualStyleBackColor = true;
            this.btColaboradores.Click += new System.EventHandler(this.btColaboradores_Click);
            // 
            // btInício
            // 
            this.btInício.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btInício.FlatAppearance.BorderSize = 0;
            this.btInício.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInício.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btInício.ForeColor = System.Drawing.Color.White;
            this.btInício.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btInício.Location = new System.Drawing.Point(9, 210);
            this.btInício.Name = "btInício";
            this.btInício.Size = new System.Drawing.Size(231, 48);
            this.btInício.TabIndex = 1;
            this.btInício.Text = "Início";
            this.btInício.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInício.UseVisualStyleBackColor = false;
            this.btInício.Click += new System.EventHandler(this.btInício_Click);
            // 
            // btPacientes
            // 
            this.btPacientes.FlatAppearance.BorderSize = 0;
            this.btPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPacientes.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold);
            this.btPacientes.ForeColor = System.Drawing.Color.White;
            this.btPacientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPacientes.Location = new System.Drawing.Point(9, 264);
            this.btPacientes.Name = "btPacientes";
            this.btPacientes.Size = new System.Drawing.Size(231, 48);
            this.btPacientes.TabIndex = 3;
            this.btPacientes.Text = "Pacientes";
            this.btPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPacientes.UseVisualStyleBackColor = true;
            this.btPacientes.Click += new System.EventHandler(this.btPacientes_Click);
            // 
            // pBtLateral
            // 
            this.pBtLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.pBtLateral.Location = new System.Drawing.Point(0, 210);
            this.pBtLateral.Name = "pBtLateral";
            this.pBtLateral.Size = new System.Drawing.Size(10, 47);
            this.pBtLateral.TabIndex = 2;
            // 
            // painelLogoHome
            // 
            this.painelLogoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.painelLogoHome.Controls.Add(this.pictureLogo);
            this.painelLogoHome.Location = new System.Drawing.Point(0, 0);
            this.painelLogoHome.Name = "painelLogoHome";
            this.painelLogoHome.Size = new System.Drawing.Size(243, 100);
            this.painelLogoHome.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureLogo.Location = new System.Drawing.Point(17, 15);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(208, 61);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // timerSegundos
            // 
            this.timerSegundos.Enabled = true;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // lblFaculdadeEGrupo
            // 
            this.lblFaculdadeEGrupo.AutoSize = true;
            this.lblFaculdadeEGrupo.Font = new System.Drawing.Font("Josefin Sans", 9F);
            this.lblFaculdadeEGrupo.ForeColor = System.Drawing.Color.White;
            this.lblFaculdadeEGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFaculdadeEGrupo.Location = new System.Drawing.Point(268, 691);
            this.lblFaculdadeEGrupo.Name = "lblFaculdadeEGrupo";
            this.lblFaculdadeEGrupo.Size = new System.Drawing.Size(977, 19);
            this.lblFaculdadeEGrupo.TabIndex = 19;
            this.lblFaculdadeEGrupo.Text = "FATEC Indaiatuba-Dr. Archimedes Lammoglia-2º Semestre Curso Análise e Desenvolvim" +
    "ento de Sistemas-Alex Rebello-Bruno Gino-Bruno Rigão-Gilmar Scarpellini-Thiago F" +
    "ranca";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1280, 719);
            this.Controls.Add(this.lblFaculdadeEGrupo);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.btMinimizar);
            this.Controls.Add(this.btMaximizar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TelaPrincipal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            this.painelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.painelLogoHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btConfigurações;
        private System.Windows.Forms.Button btAjuda;
        private System.Windows.Forms.Button btAgendamentos;
        private System.Windows.Forms.Button btColaboradores;
        private System.Windows.Forms.Button btInício;
        private System.Windows.Forms.Button btPacientes;
        private System.Windows.Forms.Panel pBtLateral;
        private System.Windows.Forms.Panel painelLogoHome;
        private System.Windows.Forms.PictureBox pictureLogo;
        private PictureBoxRedonda UserPicture;
        private System.Windows.Forms.Timer timerSegundos;
        private ucInício ucInício1;
        private System.Windows.Forms.Label lblFaculdadeEGrupo;
    }
}