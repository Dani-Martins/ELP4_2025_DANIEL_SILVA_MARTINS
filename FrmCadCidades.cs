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
        Controller aCtrl;
        public FrmCadCidades()
        {
            InitializeComponent();
        }

        protected override void Salvar()
        {
            // Se o campo de texto do código estiver vazio, atribua "0" a ele.
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }

            // Agora que o campo não está vazio, a conversão funcionará.
            oCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.Ddd = txtDdd.Text;
            oCidade.OEstado = (Estados)cboEstado.SelectedItem;
        }

        protected override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oCidade.Codigo);
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDdd.Text = oCidade.Ddd;

            // Carrega o ComboBox para o Estado do objeto Cidade
            this.cboEstado.SelectedItem = oCidade.OEstado;
        }

        protected override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();
            this.cboEstado.SelectedIndex = -1; // Limpa a seleção do ComboBox
        }

        protected override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDdd.Enabled = false;
            this.cboEstado.Enabled = false;
        }

        protected override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled = true;
            this.cboEstado.Enabled = true;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void FrmCadCidades_Load(object sender, EventArgs e)
        {
            // Preenche o ComboBox com a lista de estados
            // cboEstado.DataSource = aCtrl.getEstados();
            cboEstado.DisplayMember = "Estado";
        }
    }
}
