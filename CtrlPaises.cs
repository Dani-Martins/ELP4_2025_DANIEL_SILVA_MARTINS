using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class CtrlPaises : Controller<Paises>
    {
        ColPaises aColPaises;
        DaoPaises aDaoPaises;

        public CtrlPaises()
        {
            aColPaises = new ColPaises();
            aDaoPaises = new DaoPaises();
        }

        public override string Salvar(object obj)
        {
            return aDaoPaises.Salvar(obj);
        }
    }
}
