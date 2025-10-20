using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class ColCidades : Colecoes<Cidades>
    {
        public Cidades BuscarPorNome(string nome)
        {
            foreach (var oCidade in aLista)
            {
                if (oCidade.Cidade.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return oCidade;
                }
            }
            return null;
        }

        public Cidades BuscarPorDdd(string ddd)
        {
            foreach (var oCidade in aLista)
            {
                if (oCidade.Ddd.Equals(ddd, StringComparison.OrdinalIgnoreCase))
                {
                    return oCidade;
                }
            }
            return null;
        }

        public Cidades BuscarPorEstado(string estado)
        {
            foreach (var oCidade in aLista)
            {
                if (oCidade.OEstado.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                {
                    return oCidade;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oCidade in aLista)
            {
                Console.WriteLine($"Código: {oCidade.Codigo}");
                Console.WriteLine($"Cidade: {oCidade.Cidade}");
                Console.WriteLine($"DDD: {oCidade.Ddd}");
                Console.WriteLine($"Estado: {oCidade.OEstado.Estado}");
            }
        }
    }
}
