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
    public class RepositorioADOReserva : RepositorioBase<Reserva>, IRepositorioReserva
    {
        public RepositorioADOReserva()
        {
            _tabela = "Reserva";
        }

        public Reserva Insert(Reserva obj)
        {


            //comando sql de insert
            var sql = @"INSERT INTO Reserva
                               (Id
                               ,DataCheckIn
                               ,DataCheckOut
                               ,QtdeAdt
                               ,QtdeChd
                               ,TipoUhId
                               ,Observacoes
                               ,Situacao
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@DataCheckIn
                               ,@DataCheckOut
                               ,@QtdeAdt
                               ,@QtdeChd
                               ,@TipoUhId
                               ,@Observacoes
                               ,@Situacao
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(Reserva obj)
        {
            //comando sql de update
            var sql = @"UPDATE Reserva SET
                                DataCheckIn = @DataCheckIn
                               ,DataCheckOut = @DataCheckOut
                               ,QtdeAdt = @QtdeAdt
                               ,QtdeChd = @QtdeChd
                               ,TipoUhId = @TipoUhId
                               ,Observacoes = @Observacoes
                               ,Situacao = @Situacao
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Reserva ExecutarComando(string sql, Reserva obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("DataCheckOut", obj.DataCheckOut);
                        comando.Parameters.AddWithValue("QtdeAdt", obj.QtdeAdt);
                        comando.Parameters.AddWithValue("QtdeChd", obj.QtdeChd);
                        comando.Parameters.AddWithValue("TipoUhId", obj.TipoUh.Id);
                        comando.Parameters.AddWithValue("Observacoes", obj.Observacoes);
                        comando.Parameters.AddWithValue("Situacao", obj.Situacao);

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

        protected override List<Reserva> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Reserva>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var reserva = new Reserva();

                    reserva.Id = (Guid)reader["Id"];
                    reserva.DataCheckIn = Convert.ToDateTime(reader["DataCheckIn"]);
                    reserva.DataCheckOut = Convert.ToDateTime(reader["DataCheckOut"]);
                    reserva.QtdeAdt = Convert.ToInt32(reader["QtdeAdt"]);
                    reserva.QtdeChd = Convert.ToInt32(reader["QtdeChd"]);
                    reserva.TipoUh = new RepositorioADOTipoUh().GetById((Guid)reader["TipoUhId"]);
                    reserva.Observacoes = reader["Observacoes"].ToString();
                    reserva.Situacao = (EnSituacaoReserva)Convert.ToInt32(reader["Situacao"]);
                    reserva.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        reserva.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(reserva);
                }
            }

            return lista;
        }
    }
}
