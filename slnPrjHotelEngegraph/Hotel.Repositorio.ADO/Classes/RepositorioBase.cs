using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Utils.Database;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Classes
{
    public abstract class RepositorioBase<T> where T: Entidade
    {
        protected abstract T ExecutarComando(string sql, T obj, EnOperacao pOperacao = EnOperacao.Insert);

        protected SqlCommand CriarComando(string pSql = "")
        {
            var conn = Conexao.Conectar();
            var comando = conn.CreateCommand();
            comando.CommandText = pSql;
            return comando;
        }

        protected abstract List<T> ObterLista(SqlCommand pComando);

        protected virtual DataTable ObterTabela(string pSql)
        {
            var comando = CriarComando(pSql);

            try
            {
                var adapter = new SqlDataAdapter(comando);
                DataTable resultado = new DataTable();
                adapter.Fill(resultado);
                return resultado;
            }
            finally
            {
                comando.FreeAndNil();
            }
        }
    }
}
