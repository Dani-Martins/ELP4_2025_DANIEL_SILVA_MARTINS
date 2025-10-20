using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class CtrlEstados : Controller<Estados>
    {
        ColEstados aColEstados;
        DaoEstados aDaoEstados;

        public CtrlEstados()
        {
            aColEstados = new ColEstados();
            aDaoEstados = new DaoEstados();
        }

        public override string Salvar(object obj)
        {
            return aDaoEstados.Salvar(obj);
        }
    }
}
