using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_elp
{
    public partial class FrmConsPaises : projeto_elp.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        Controller aCtrl;
        public FrmConsPaises()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
        }

        protected override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }

        protected override void Excluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }

        public override void setFrmCadastro(Object obj)
        {
            if (obj != null)
                oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void FrmConsPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
