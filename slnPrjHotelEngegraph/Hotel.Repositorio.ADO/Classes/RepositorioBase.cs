using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Utils.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Hotel.Repositorio.ADO.Classes
{
    public abstract class RepositorioBase<T> where T: Entidade
    {
        protected string _tabela;

        protected abstract T ExecutarComando(string sql, T obj, EnOperacao pOperacao = EnOperacao.Insert);
        protected abstract List<T> ObterLista(SqlCommand pComando);

        protected SqlCommand CriarComando(string pSql = "")
        {
            var conn = Conexao.Conectar();
            var comando = conn.CreateCommand();
            comando.CommandText = pSql;
            return comando;
        }

        public virtual void Delete(Guid id)
        {
            var sql = $@"DELETE FROM {_tabela}
                        WHERE 
                            Id = @Id";

            var obj = Activator.CreateInstance<T>();
            obj.Id = id;

            ExecutarComando(sql, obj, EnOperacao.Delete);
        }

        public virtual T GetById(Guid id)
        {
            var comando = CriarComando();

            try
            {
                var sql = $"SELECT * FROM {_tabela} WHERE Id = @Id";

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("Id", id);
                return ObterLista(comando).FirstOrDefault();
            }
            finally
            {
                comando.FreeAndNil();
            }
        }

        public virtual DataTable GetDataTable()
        {
            var comando = CriarComando($"SELECT * FROM {_tabela}");

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

        public virtual List<T> List()
        {
            var comando = CriarComando();

            try
            {
                var sql = $"SELECT * FROM {_tabela}";

                comando.CommandText = sql;

                return ObterLista(comando);
            }
            finally
            {
                comando.FreeAndNil();
            }
        }
    }
}
