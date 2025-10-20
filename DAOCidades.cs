using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_elp
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidade.Codigo == 0)
            {
                mSql = "INSERT INTO Cidades (Cidade, DDD, DatCad, UltAlt) VALUES (@cidade, @ddd, @datcad, @ultalt)";
            }
            else
                mSql = "UPDATE Cidades set cidade = @cidade, ddd = @ddd, datcad = @datcad, ultalt = @ultalt where codigo = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                cmd.Parameters.AddWithValue("@cidade", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", aCidade.Ddd);
                cmd.Parameters.AddWithValue("@datcad", aCidade.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", aCidade.UltAlt);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override List<Cidades> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return null;
        }
    }
}
