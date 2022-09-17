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
    public class RepositorioADOConfiguracao : RepositorioBase<Configuracao>, IRepositorioConfiguracao
    {
        public RepositorioADOConfiguracao()
        {
            _tabela = "Configuracao";
        }

        public Configuracao Insert(Configuracao obj)
        {
            //comando sql de insert
            var sql = $@"INSERT INTO Configuracao
                               (Id
                               ,Codigo
                               ,Descricao
                               ,Valor
                               ,Tipo
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Codigo
                               ,@Descricao
                               ,@Valor
                               ,@Tipo
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(Configuracao obj)
        {
            //comando sql de update
            var sql = @"UPDATE Configuracao SET
                               Valor = @Valor
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Configuracao ExecutarComando(string sql, Configuracao obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        var agora = DateTime.Now;

                        Guid id;

                        if (pOperacao == EnOperacao.Insert)
                        {
                            id = Guid.NewGuid();
                            comando.Parameters.AddWithValue("Codigo", obj.Codigo);
                            comando.Parameters.AddWithValue("Descricao", obj.Descricao);
                            comando.Parameters.AddWithValue("Valor", obj.Valor);
                            comando.Parameters.AddWithValue("Tipo", obj.Tipo);

                            comando.Parameters.AddWithValue("DataCriacao", agora);
                        }
                        else
                        {
                            id = obj.Id;
                            comando.Parameters.AddWithValue("Valor", obj.Valor);
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

        protected override List<Configuracao> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Configuracao>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var configuracao = new Configuracao();

                    configuracao.Id = (Guid)reader["Id"];
                    configuracao.Codigo = Convert.ToInt32(reader["Codigo"]);
                    configuracao.Descricao = reader["Descricao"].ToString();
                    configuracao.Valor = reader["Valor"].ToString();
                    configuracao.Tipo = (EnTipoConfiguracao)Convert.ToInt32(reader["Tipo"]);
                    configuracao.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        configuracao.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(configuracao);
                }
            }

            return lista;
        }
    }
}
