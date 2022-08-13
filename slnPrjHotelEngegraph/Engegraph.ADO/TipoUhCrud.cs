using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engegraph.ADO
{
    enum EnOperacao
    {
        Insert = 0,
        Update = 1,
        Delete = 2
    }

    class FiltroTipoUH
    {
        public string Id { get; set; }
        public string Descricao { get; set; } 
    }

    //CRUD

    class TipoUhCrud
    {
        private readonly SqlConnection _conexao;

        public TipoUhCrud(SqlConnection pConexao)
        {
            _conexao = pConexao;
            _conexao.Open();
        }

        private void ExecutarComando(string sql, TipoUh pTipoUh, EnOperacao pOperacao = EnOperacao.Insert)
        {
            //instancia um novo SqlCommand
            var comando = CriarComando(sql);

            //Adiciona parametros com o seus respectivos valores
            comando.Parameters.AddWithValue("Id", pTipoUh.Id);

            if(pOperacao != EnOperacao.Delete)
            {
                comando.Parameters.AddWithValue("Descricao", pTipoUh.Descricao);
                comando.Parameters.AddWithValue("QtdeAdt", pTipoUh.QtdeAdt);
                comando.Parameters.AddWithValue("QtdeChd", pTipoUh.QtdeChd);
                comando.Parameters.AddWithValue("ValorDiaria", pTipoUh.ValorDiaria);
                comando.Parameters.AddWithValue("ValorAdicional", pTipoUh.ValorAdicional);

                var agora = DateTime.Now;

                if (pOperacao == EnOperacao.Insert)
                    comando.Parameters.AddWithValue("DataCriacao", agora);
                else
                    comando.Parameters.AddWithValue("DataModificacao", agora);
            }

            //Executa um comando de NÃO consulta
            comando.ExecuteNonQuery();
        }

        private SqlCommand CriarComando(string pSql)
        {
            var comando = _conexao.CreateCommand();
            comando.CommandText = pSql;
            return comando;
        }


        public void Create(TipoUh pTipoUh)
        {
            //comando sql de insert
            var sql = @"INSERT INTO TipoUh
                               (Id
                               ,Descricao
                               ,QtdeAdt
                               ,QtdeChd
                               ,ValorDiaria
                               ,ValorAdicional
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Descricao
                               ,@QtdeAdt
                               ,@QtdeChd
                               ,@ValorDiaria
                               ,@ValorAdicional
                               ,@DataCriacao);";

            ExecutarComando(sql, pTipoUh);
        }

        public List<TipoUh> Read()
        {
            var sql = "SELECT * FROM TipoUh";

            var comando = CriarComando(sql);

            return ObterListaTipoUh(comando);
        }

        public List<TipoUh> Read(FiltroTipoUH pFiltro)
        {
            var sql = "SELECT * FROM TipoUh WHERE ";

            var condicoes = new List<string>();

            var comando = CriarComando(sql);

            if (!string.IsNullOrWhiteSpace(pFiltro.Id))
            {
                condicoes.Add("Id = @Id");
                comando.Parameters.AddWithValue("Id", pFiltro.Id);
            }
                
            if (!string.IsNullOrWhiteSpace(pFiltro.Descricao))
            {
                condicoes.Add("Descricao LIKE @Descricao");
                comando.Parameters.AddWithValue("Descricao", pFiltro.Descricao + "%");
            }

            sql += string.Join(" AND ", condicoes.ToArray());

            comando.CommandText = sql;

            return ObterListaTipoUh(comando);
        }

        private List<TipoUh> ObterListaTipoUh(SqlCommand pComando)
        {
            var listaTiposUh = new List<TipoUh>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var tipoUh = new TipoUh();

                    tipoUh.Id = (Guid)reader["Id"];
                    tipoUh.Descricao = reader["Descricao"].ToString();
                    tipoUh.QtdeAdt = Convert.ToInt32(reader["QtdeAdt"]);
                    tipoUh.QtdeChd = Convert.ToInt32(reader["QtdeChd"]);
                    tipoUh.ValorDiaria = Convert.ToDouble(reader["ValorDiaria"]);
                    tipoUh.ValorAdicional = Convert.ToDouble(reader["ValorAdicional"]);
                    tipoUh.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        tipoUh.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    listaTiposUh.Add(tipoUh);
                }
            }

            return listaTiposUh;
        }

        public void Update(TipoUh pTipoUh)
        {
            //update

            //comando sql de update
            var sql = @"UPDATE TipoUh SET
                               Descricao = @Descricao
                               ,QtdeAdt = @QtdeAdt
                               ,QtdeChd = @QtdeChd
                               ,ValorDiaria = @ValorDiaria
                               ,ValorAdicional = @ValorAdicional
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, pTipoUh, EnOperacao.Update);
        }

        public void Delete(Guid pId)
        {
            var sql = @"DELETE FROM TipoUh 
                        WHERE 
                            Id = @Id";

            ExecutarComando(sql, new TipoUh() { Id = pId }, EnOperacao.Delete);
        }
    }
}
