using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmCadPaises : projeto_elp.FrmCadastros
    {
        Paises oPais;
        Controller aCtrl;
        public FrmCadPaises()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            //   if (Message Dlg("Confirma (S/N)") == "S")
            oPais.Codigo = Convert.ToInt32(txtCodigo.Text);
            oPais.Sigla = txtSigla.Text;
            oPais.Ddi = txtDDI.Text;
            oPais.Moeda = txtMoeda.Text;
            oPais.Pais = txtPais.Text;
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtSigla.Text = oPais.Sigla;
            this.txtDDI.Text = oPais.Ddi;
            this.txtMoeda.Text = oPais.Moeda;
            this.txtPais.Text = oPais.Pais;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtSigla.Clear();
            this.txtDDI.Clear();
            this.txtMoeda.Clear();
            this.txtPais.Clear();
        }

        public override void BloquearTxt()
        {
            this.txtPais.Enabled = false;
            this.txtDDI.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtMoeda.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtPais.Enabled = true;
            this.txtDDI.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtMoeda.Enabled = true;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void FrmCadPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
