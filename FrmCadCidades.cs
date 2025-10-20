using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmCadCidades : projeto_elp.FrmCadastros
    {
        Cidades oCidade;
        CtrlCidades aCtrlCidades;

        FrmConsEstados oFrmConsEstados;
        public FrmCadCidades()
        {
            InitializeComponent();
        }

        public void setFrmConsEstados(object obj)
        {
            if (obj != null)
            {
                oFrmConsEstados = (FrmConsEstados)obj;
            }
        }

        public override void Salvar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }

            oCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.Ddd = txtDdd.Text;
            MessageBox.Show(aCtrlCidades.Salvar(oCidade));
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oCidade.Codigo);
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDdd.Text = oCidade.Ddd;

        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();
        }

        public override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDdd.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled = true;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
        }

        private void FrmCadCidades_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string obtnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(oCidade.OEstado, aCtrlCidades);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(oCidade.OEstado.Codigo);
            this.txtEstado.Text = oCidade.OEstado.ToString();
            oFrmConsEstados.btnSair = btnSair;
        }
    }
}
