namespace MarcaFácil
{
    partial class LoginScreen
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.lblMarcaDoGrupo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuário = new System.Windows.Forms.TextBox();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.picLogoLogin = new System.Windows.Forms.PictureBox();
            this.btAcessar = new System.Windows.Forms.Button();
            this.btSairPrograma = new System.Windows.Forms.Button();
            this.painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaDoGrupo
            // 
            this.lblMarcaDoGrupo.AutoSize = true;
            this.lblMarcaDoGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.lblMarcaDoGrupo.Location = new System.Drawing.Point(150, 345);
            this.lblMarcaDoGrupo.Name = "lblMarcaDoGrupo";
            this.lblMarcaDoGrupo.Size = new System.Drawing.Size(178, 13);
            this.lblMarcaDoGrupo.TabIndex = 15;
            this.lblMarcaDoGrupo.Text = "Copyright Ⓒ 2018 - MarcaFácil Ltda.";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(98, 111);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(86, 30);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(113, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(252, 22);
            this.txtSenha.TabIndex = 13;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(102, 201);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(72, 30);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuário
            // 
            this.txtUsuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuário.Location = new System.Drawing.Point(113, 148);
            this.txtUsuário.Name = "txtUsuário";
            this.txtUsuário.Size = new System.Drawing.Size(252, 22);
            this.txtUsuário.TabIndex = 11;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.painelPrincipal.Controls.Add(this.btSairPrograma);
            this.painelPrincipal.Controls.Add(this.picLogoLogin);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(484, 83);
            this.painelPrincipal.TabIndex = 10;
            // 
            // picLogoLogin
            // 
            this.picLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogoLogin.Image")));
            this.picLogoLogin.Location = new System.Drawing.Point(12, 6);
            this.picLogoLogin.Name = "picLogoLogin";
            this.picLogoLogin.Size = new System.Drawing.Size(218, 68);
            this.picLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoLogin.TabIndex = 0;
            this.picLogoLogin.TabStop = false;
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btAcessar.FlatAppearance.BorderSize = 0;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.Font = new System.Drawing.Font("Josefin Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcessar.ForeColor = System.Drawing.Color.White;
            this.btAcessar.Location = new System.Drawing.Point(192, 284);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(92, 37);
            this.btAcessar.TabIndex = 16;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // btSairPrograma
            // 
            this.btSairPrograma.BackColor = System.Drawing.Color.Transparent;
            this.btSairPrograma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btSairPrograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btSairPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btSairPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairPrograma.Font = new System.Drawing.Font("Josefin Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairPrograma.Location = new System.Drawing.Point(451, 3);
            this.btSairPrograma.Name = "btSairPrograma";
            this.btSairPrograma.Size = new System.Drawing.Size(30, 27);
            this.btSairPrograma.TabIndex = 1;
            this.btSairPrograma.Text = "X";
            this.btSairPrograma.UseVisualStyleBackColor = false;
            this.btSairPrograma.Click += new System.EventHandler(this.btSairPrograma_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.lblMarcaDoGrupo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuário);
            this.Controls.Add(this.painelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.btAcessar_Click);
            this.painelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarcaDoGrupo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuário;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.PictureBox picLogoLogin;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.Button btSairPrograma;
    }
}

