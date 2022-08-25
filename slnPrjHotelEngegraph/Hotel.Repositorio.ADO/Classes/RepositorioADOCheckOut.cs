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
    public class RepositorioADOCheckOut : RepositorioBase<CheckOut>, IRepositorioCheckOut
    {

        public RepositorioADOCheckOut()
        {
            _tabela = "CheckOut";
        }

        public CheckOut Insert(CheckOut obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO CheckOut
                               (Id
                               ,DataCheckOut
                               ,OcupacaoId
                               ,TipoPagtoId
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@DataCheckOut
                               ,@OcupacaoId
                               ,@TipoPagtoId
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(CheckOut obj)
        {
            //comando sql de update
            var sql = @"UPDATE CheckOut SET
                                DataCheckOut = DataCheckOut
                               ,OcupacaoId = OcupacaoId
                               ,TipoPagtoId = TipoPagtoId
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override CheckOut ExecutarComando(string sql, CheckOut obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("DataCheckOut", obj.DataCheckOut);
                        comando.Parameters.AddWithValue("OcupacaoId", obj.Ocupacao.Id);
                        comando.Parameters.AddWithValue("TipoPagtoId", obj.TipoPagto.Id);

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

        protected override List<CheckOut> ObterLista(SqlCommand pComando)
        {
            var lista = new List<CheckOut>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var checkOut = new CheckOut();

                    checkOut.Id = (Guid)reader["Id"];
                    checkOut.DataCheckOut = Convert.ToDateTime(reader["DataCheckOut"]);
                    checkOut.Ocupacao = new RepositorioADOOcupacao().GetById((Guid)reader["OcupacaoId"]);
                    checkOut.TipoPagto = new RepositorioADOTipoPagto().GetById((Guid)reader["OcupacaoId"]);
                    checkOut.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        checkOut.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(checkOut);
                }
            }

            return lista;
        }
    }
}
