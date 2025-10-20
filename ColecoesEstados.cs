using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class ColEstados : Colecoes<Estados>
    {
        public Estados BuscarPorSigla(string uf)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.Uf.Equals(uf, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }

        public Estados BuscarPorPais(string pais)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.OPais.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oEstado in aLista)
            {
                Console.WriteLine($"Código: {oEstado.Codigo}");
                Console.WriteLine($"Estado: {oEstado.Estado}");
                Console.WriteLine($"UF: {oEstado.Uf}");
                Console.WriteLine($"País: {oEstado.OPais.Pais}");
            }
        }
    }
}
