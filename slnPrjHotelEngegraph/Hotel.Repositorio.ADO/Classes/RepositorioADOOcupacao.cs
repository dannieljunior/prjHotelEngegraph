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
    public class RepositorioADOOcupacao : RepositorioBase<Ocupacao>, IRepositorioOcupacao
    {
        public RepositorioADOOcupacao()
        {
            _tabela = "Ocupacao";
        }

        public Ocupacao Insert(Ocupacao obj)
        {

            //comando sql de insert
            var sql = @"INSERT INTO Ocupacao
                               (Id
                               ,DataCheckIn
                               ,Situacao
                               ,ReservaId
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@DataCheckIn
                               ,@Situacao
                               ,@ReservaId
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public List<Ocupacao> List()
        {
            var comando = CriarComando();

            try
            {
                var sql = "SELECT * FROM Ocupacao";

                comando.CommandText = sql;

                return ObterLista(comando);
            }
            finally
            {
                comando.FreeAndNil();
            }
        }

        public void Update(Ocupacao obj)
        {
            //comando sql de update
            var sql = @"UPDATE Ocupacao SET
                               ,DataCheckIn = @DataCheckIn
                               ,Situacao = @Situacao
                               ,ReservaId = @ReservaId
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Ocupacao ExecutarComando(string sql, Ocupacao obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("DataCheckIn", obj.DataCheckIn);
                        comando.Parameters.AddWithValue("Situacao", obj.Situacao);
                        comando.Parameters.AddWithValue("ReservaId", obj.Reserva.Id);

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

        protected override List<Ocupacao> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Ocupacao>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var ocupacao = new Ocupacao();

                    ocupacao.Id = (Guid)reader["Id"];
                    ocupacao.DataCheckIn = Convert.ToDateTime(reader["DataCheckIn"]);
                    ocupacao.Situacao = (EnSituacaoOcupacao)Convert.ToInt32(reader["Situacao"]);
                    ocupacao.Reserva = new RepositorioADOReserva().GetById((Guid)reader["ReservaId"]);
                    ocupacao.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        ocupacao.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(ocupacao);
                }
            }

            return lista;
        }
    }
}
