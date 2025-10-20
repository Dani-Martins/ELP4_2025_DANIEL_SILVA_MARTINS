using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class ColPaises : Colecoes<Paises>
    {
        public Paises BuscarPorSigla(string sigla)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }

        public Paises BuscarPorDDI(string ddi)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Ddi.Equals(ddi, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }

        public Paises BuscarPorMoeda(string moeda)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Moeda.Equals(moeda, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }

        public override void Imprimir()
        {
            foreach (var oPais in aLista)
            {
                Console.WriteLine($"Código: {oPais.Codigo}");
                Console.WriteLine($"Pais: {oPais.Pais}");
                Console.WriteLine($"Sigla: {oPais.Sigla}");
                Console.WriteLine($"DDI: {oPais.Ddi}");
                Console.WriteLine($"Moeda: {oPais.Moeda}");
            }
        }
    }
}
