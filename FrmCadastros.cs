using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmCadastros : projeto_elp.Frm
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }

        public virtual void Salvar()
        {

        }

        public virtual void CarregaTxt()
        {

        }

        public virtual void LimpaTxt()
        {

        }

        public virtual void BloquearTxt()
        {

        }

        public virtual void DesbloquearTxt()
        {

        }

        private void FrmCadastros_Load(object sender, EventArgs e)
        {

        }
    }
}
