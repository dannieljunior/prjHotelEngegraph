using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Utils.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Hotel.Repositorio.ADO.Classes
{
    public class RepositorioADOTipoPagto : RepositorioBase<TipoPagto>, IRepositorioTipoPagto
    {

        public RepositorioADOTipoPagto()
        {
            _tabela = "TipoPagto";
        }

        public TipoPagto Insert(TipoPagto obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO TipoPagto
                               (Id
                               ,Descricao
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Descricao
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(TipoPagto obj)
        {
            //comando sql de update
            var sql = @"UPDATE TipoPagto SET
                               Descricao = @Descricao
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override TipoPagto ExecutarComando(string sql, TipoPagto obj, EnOperacao pOperacao = EnOperacao.Insert)
        {
            var comando = CriarComando(sql);

            try
            {
                //Adiciona parametros com o seus respectivos valores

                if (pOperacao == EnOperacao.Delete)
                {
                    comando.Parameters.AddWithValue("Id", obj.Id);
                }
                else
                {
                    if (pOperacao != EnOperacao.Delete)
                    {
                        comando.Parameters.AddWithValue("Descricao", obj.Descricao);

                        var agora = DateTime.Now;

                        Guid id;

                        if (pOperacao == EnOperacao.Insert)
                        {
                            id = Guid.NewGuid();
                            comando.Parameters.AddWithValue("DataCriacao", agora);
                        }
                        else
                        {
                            id = obj.Id;
                            comando.Parameters.AddWithValue("DataModificacao", agora);
                        }

                        obj.Id = id;

                        comando.Parameters.AddWithValue("Id", obj.Id);
                    }
                }

                //Executa um comando de NÃO consulta
                comando.ExecuteNonQuery();

                return obj;
            }
            finally
            {
                comando.FreeAndNil();
            }
        }

        protected override List<TipoPagto> ObterLista(SqlCommand pComando)
        {
            var lista = new List<TipoPagto>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var tipoPagto = new TipoPagto();

                    tipoPagto.Id = (Guid)reader["Id"];
                    tipoPagto.Descricao = reader["Descricao"].ToString();
                    tipoPagto.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        tipoPagto.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(tipoPagto);
                }
            }

            return lista;
        }
    }
}
