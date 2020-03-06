namespace MarcaFácil
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblMarcaDoGrupo = new System.Windows.Forms.Label();
            this.lblTextoAleatório = new System.Windows.Forms.Label();
            this.barraDeCarregamento = new System.Windows.Forms.ProgressBar();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.picLogoSplash = new System.Windows.Forms.PictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.timerTexto = new System.Windows.Forms.Timer(this.components);
            this.painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaDoGrupo
            // 
            this.lblMarcaDoGrupo.AutoSize = true;
            this.lblMarcaDoGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.lblMarcaDoGrupo.Location = new System.Drawing.Point(150, 345);
            this.lblMarcaDoGrupo.Name = "lblMarcaDoGrupo";
            this.lblMarcaDoGrupo.Size = new System.Drawing.Size(178, 13);
            this.lblMarcaDoGrupo.TabIndex = 7;
            this.lblMarcaDoGrupo.Text = "Copyright Ⓒ 2018 - MarcaFácil Ltda.";
            // 
            // lblTextoAleatório
            // 
            this.lblTextoAleatório.AutoSize = true;
            this.lblTextoAleatório.Font = new System.Drawing.Font("Josefin Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAleatório.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.lblTextoAleatório.Location = new System.Drawing.Point(72, 243);
            this.lblTextoAleatório.Name = "lblTextoAleatório";
            this.lblTextoAleatório.Size = new System.Drawing.Size(0, 19);
            this.lblTextoAleatório.TabIndex = 6;
            // 
            // barraDeCarregamento
            // 
            this.barraDeCarregamento.Location = new System.Drawing.Point(72, 213);
            this.barraDeCarregamento.Name = "barraDeCarregamento";
            this.barraDeCarregamento.Size = new System.Drawing.Size(343, 23);
            this.barraDeCarregamento.TabIndex = 5;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(148)))));
            this.painelPrincipal.Controls.Add(this.picLogoSplash);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(484, 83);
            this.painelPrincipal.TabIndex = 4;
            // 
            // picLogoSplash
            // 
            this.picLogoSplash.Image = ((System.Drawing.Image)(resources.GetObject("picLogoSplash.Image")));
            this.picLogoSplash.Location = new System.Drawing.Point(9, 3);
            this.picLogoSplash.Name = "picLogoSplash";
            this.picLogoSplash.Size = new System.Drawing.Size(218, 68);
            this.picLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoSplash.TabIndex = 1;
            this.picLogoSplash.TabStop = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerTexto
            // 
            this.timerTexto.Enabled = true;
            this.timerTexto.Tick += new System.EventHandler(this.timerTexto_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.lblMarcaDoGrupo);
            this.Controls.Add(this.lblTextoAleatório);
            this.Controls.Add(this.barraDeCarregamento);
            this.Controls.Add(this.painelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.painelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaDoGrupo;
        private System.Windows.Forms.Label lblTextoAleatório;
        private System.Windows.Forms.ProgressBar barraDeCarregamento;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.PictureBox picLogoSplash;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Timer timerTexto;
    }
}