using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class CtrlCidades : Controller<Cidades>
    {
        ColCidades aColCidades;
        DaoCidades aDaoCidades;

        public CtrlCidades()
        {
            aColCidades = new ColCidades();
            aDaoCidades = new DaoCidades();
        }

        public override string Salvar(object obj)
        {
            return aDaoCidades.Salvar(obj);
        }
    }
}
