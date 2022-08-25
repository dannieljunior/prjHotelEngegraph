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
    public class RepositorioADOHospedeOcupacao : RepositorioBase<HospedeOcupacao>, IRepositorioHospedeOcupacao
    {
        public RepositorioADOHospedeOcupacao()
        {
            _tabela = "HospedeOcupacao";
        }

        public HospedeOcupacao Insert(HospedeOcupacao obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO HospedeOcupacao
                               (Id
                               ,HospedeId
                               ,OcupacaoId
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@HospedeId
                               ,@OcupacaoId
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(HospedeOcupacao obj)
        {
            //comando sql de update
            var sql = @"UPDATE HospedeOcupacao SET
                                HospedeId = @HospedeId
                               ,OcupacaoId = @OcupacaoId
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override HospedeOcupacao ExecutarComando(string sql, HospedeOcupacao obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("HospedeId", obj.Hospede.Id);
                        comando.Parameters.AddWithValue("OcupacaoId", obj.Ocupacao.Id);

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

        protected override List<HospedeOcupacao> ObterLista(SqlCommand pComando)
        {
            var lista = new List<HospedeOcupacao>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var hospedeOcupacao = new HospedeOcupacao();

                    hospedeOcupacao.Id = (Guid)reader["Id"];
                    hospedeOcupacao.Hospede = new RepositorioADOHospede().GetById((Guid)reader["HospedeId"]);
                    hospedeOcupacao.Ocupacao = new RepositorioADOOcupacao().GetById((Guid)reader["OcupacaoId"]);
                    hospedeOcupacao.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        hospedeOcupacao.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(hospedeOcupacao);
                }
            }

            return lista;
        }
    }
}
