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
        CtrlEstados aCtrlEstados;

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
        public override void Salvar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }

            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            MessageBox.Show(aCtrlEstados.Salvar(oEstado));
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text = oEstado.Uf;

        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }

        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrlEstados = (CtrlEstados)ctrl;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadEstados_Load(object sender, EventArgs e)
        {
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string obtnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrlEstados);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.ToString();
            oFrmConsPaises.btnSair = btnSair;
        }
    }
}
