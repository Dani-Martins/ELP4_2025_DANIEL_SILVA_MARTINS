using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmConsultas : projeto_elp.Frm
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        protected virtual void Pesquisar()
        {
        }

        protected virtual void Incluir()
        {
        }

        protected virtual void Excluir()
        {
        }

        protected virtual void Alterar()
        {
        }

        protected virtual void CarregaLV()
        {
        }

        public virtual void setFrmCadastro(Object obj)
        {

        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
