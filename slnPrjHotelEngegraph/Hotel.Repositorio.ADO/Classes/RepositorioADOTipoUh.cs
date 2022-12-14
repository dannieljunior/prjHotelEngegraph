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
    public class RepositorioADOTipoUh : RepositorioBase<TipoUh>, IRepositorioTipoUh
    {
        public RepositorioADOTipoUh()
        {
            _tabela = "TipoUh";
        }

        public TipoUh Insert(TipoUh obj)
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

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(TipoUh obj)
        {
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

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override TipoUh ExecutarComando(string sql, TipoUh obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("QtdeAdt", obj.QtdeAdt);
                        comando.Parameters.AddWithValue("QtdeChd", obj.QtdeChd);
                        comando.Parameters.AddWithValue("ValorDiaria", obj.ValorDiaria);
                        comando.Parameters.AddWithValue("ValorAdicional", obj.ValorAdicional);

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

        protected override List<TipoUh> ObterLista(SqlCommand pComando)
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
    }
}
