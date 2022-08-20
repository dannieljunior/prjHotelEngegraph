using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public abstract class BllBase<T> where T: Entidade
    {
        private readonly SqlConnection _conexao;

        public BllBase(SqlConnection pConexao)
        {
            _conexao = pConexao;
        }

        protected abstract T ExecutarComando(string sql, T obj, EnOperacao pOperacao = EnOperacao.Insert);

        protected abstract List<T> ObterLista(SqlCommand pComando);

        protected SqlCommand CriarComando(string pSql)
        {
            var comando = _conexao.CreateCommand();
            comando.CommandText = pSql;
            return comando;
        }
    }
}
