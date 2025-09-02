using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmCadEstados : projeto_elp.FrmCadastros
    {
        Estados oEstado;
        Controller aCtrl;

        FrmConsPaises oFrmConsPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
        }

        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
            {
                oFrmConsPaises = (FrmConsPaises)obj;
            }
        }
        protected override void Salvar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }

            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            oEstado.OPais = (Paises)cboPais.SelectedItem;
        }

        protected override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text = oEstado.Uf;

            this.cboPais.SelectedItem = oEstado.OPais;
        }

        protected override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
            this.cboPais.SelectedIndex = -1; 
        }

        protected override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
            this.cboPais.Enabled = false;
        }

        protected override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
            this.cboPais.Enabled = true;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadEstados_Load(object sender, EventArgs e)
        {
            cboPais.DisplayMember = "Pais"; 
        }
    }
}
