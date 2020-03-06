namespace MarcaFácil
{
    partial class Ajuda
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
            this.listAbasAjuda = new System.Windows.Forms.ListBox();
            this.painelDeImagem = new System.Windows.Forms.Panel();
            this.labelAba = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.pictureAbasHelper = new System.Windows.Forms.PictureBox();
            this.painelDeImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbasHelper)).BeginInit();
            this.SuspendLayout();
            // 
            // listAbasAjuda
            // 
            this.listAbasAjuda.Font = new System.Drawing.Font("Josefin Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAbasAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listAbasAjuda.FormattingEnabled = true;
            this.listAbasAjuda.ItemHeight = 27;
            this.listAbasAjuda.Items.AddRange(new object[] {
            "Início",
            "Aba Agendamentos",
            "Criando agendamento",
            "Aba Paciente",
            "Adicionando paciente",
            "Aba Colaboradores",
            "Adicionando colaborador",
            "Aba Configurações",
            "Alterando configurações"});
            this.listAbasAjuda.Location = new System.Drawing.Point(60, 59);
            this.listAbasAjuda.Name = "listAbasAjuda";
            this.listAbasAjuda.Size = new System.Drawing.Size(903, 112);
            this.listAbasAjuda.TabIndex = 50;
            this.listAbasAjuda.SelectedIndexChanged += new System.EventHandler(this.listAbasAjuda_SelectedIndexChanged);
            // 
            // painelDeImagem
            // 
            this.painelDeImagem.BackColor = System.Drawing.Color.White;
            this.painelDeImagem.Controls.Add(this.pictureAbasHelper);
            this.painelDeImagem.Controls.Add(this.labelAba);
            this.painelDeImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelDeImagem.Location = new System.Drawing.Point(60, 207);
            this.painelDeImagem.Name = "painelDeImagem";
            this.painelDeImagem.Size = new System.Drawing.Size(903, 418);
            this.painelDeImagem.TabIndex = 49;
            // 
            // labelAba
            // 
            this.labelAba.AutoSize = true;
            this.labelAba.Font = new System.Drawing.Font("Josefin Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAba.Location = new System.Drawing.Point(30, 382);
            this.labelAba.Name = "labelAba";
            this.labelAba.Size = new System.Drawing.Size(164, 27);
            this.labelAba.TabIndex = 0;
            this.labelAba.Text = "<Aba selecionada>";
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.White;
            this.lblAjuda.Location = new System.Drawing.Point(55, 18);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(85, 38);
            this.lblAjuda.TabIndex = 48;
            this.lblAjuda.Text = "Ajuda";
            // 
            // pictureAbasHelper
            // 
            this.pictureAbasHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAbasHelper.Location = new System.Drawing.Point(0, 0);
            this.pictureAbasHelper.Name = "pictureAbasHelper";
            this.pictureAbasHelper.Size = new System.Drawing.Size(903, 418);
            this.pictureAbasHelper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAbasHelper.TabIndex = 1;
            this.pictureAbasHelper.TabStop = false;
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.listAbasAjuda);
            this.Controls.Add(this.painelDeImagem);
            this.Controls.Add(this.lblAjuda);
            this.Name = "Ajuda";
            this.Size = new System.Drawing.Size(1019, 642);
            this.painelDeImagem.ResumeLayout(false);
            this.painelDeImagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbasHelper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAbasAjuda;
        private System.Windows.Forms.Panel painelDeImagem;
        private System.Windows.Forms.PictureBox pictureAbasHelper;
        private System.Windows.Forms.Label labelAba;
        private System.Windows.Forms.Label lblAjuda;
    }
}
