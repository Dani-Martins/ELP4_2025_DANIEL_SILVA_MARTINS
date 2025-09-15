namespace projeto_elp
{
    partial class FrmCadPaises
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDDI = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(90, 5);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "Pais";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(278, 5);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 11;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(334, 5);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 12;
            this.lblDDI.Text = "DDI";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(390, 5);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 13;
            this.lblMoeda.Text = "Moeda";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(93, 21);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(182, 20);
            this.txtPais.TabIndex = 0;
            this.txtPais.UseSystemPasswordChar = true;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(281, 21);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(41, 20);
            this.txtSigla.TabIndex = 15;
            // 
            // txtDDI
            // 
            this.txtDDI.Location = new System.Drawing.Point(337, 21);
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(50, 20);
            this.txtDDI.TabIndex = 16;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(393, 21);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(32, 20);
            this.txtMoeda.TabIndex = 17;
            // 
            // FrmCadPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Name = "FrmCadPaises";
            this.Text = "Cadastros de Paises";
            this.Load += new System.EventHandler(this.FrmCadPaises_Load);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtDatacad, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodUsu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDDI;
        private System.Windows.Forms.TextBox txtMoeda;
    }
}
