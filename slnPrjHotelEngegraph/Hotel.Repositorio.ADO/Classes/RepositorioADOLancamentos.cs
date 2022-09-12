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
    public class RepositorioADOLancamentos : RepositorioBase<Lancamentos>, IRepositorioLancamentos
    {

        public RepositorioADOLancamentos()
        {
            _tabela = "Lancamentos";
        }

        public Lancamentos Insert(Lancamentos obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO Lancamentos
                               (Id
                               ,Valor
                               ,CheckOutId
                               ,TipoPagtoId
                               ,Conta
                               ,Data 
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Valor
                               ,@CheckOutId
                               ,@TipoPagtoId
                               ,@Conta
                               ,@Data
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(Lancamentos obj)
        {
            //comando sql de update
            var sql = @"UPDATE Lancamentos SET
                                Id = @Id
                               ,Valor = @Valor
                               ,CheckOutId = @CheckOutId
                               ,TipoPagtoId = @TipoPagtoId
                               ,Conta = @Conta
                               ,Data = @Data
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Lancamentos ExecutarComando(string sql, Lancamentos obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("Valor", obj.Valor);
                        comando.Parameters.AddWithValue("CheckOutId", obj.CheckOut.Id);
                        comando.Parameters.AddWithValue("TipoPagtoId", obj.TipoPagto.Id);
                        comando.Parameters.AddWithValue("Conta", obj.Conta);
                        comando.Parameters.AddWithValue("Data", obj.Data);

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

        protected override List<Lancamentos> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Lancamentos>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var checkOut = new Lancamentos();

                    checkOut.Id = (Guid)reader["Id"];
                    checkOut.Valor = reader.GetDouble(1);
                    checkOut.CheckOut = new RepositorioADOCheckOut().GetById((Guid)reader["CheckOutId"]);
                    checkOut.TipoPagto = new RepositorioADOTipoPagto().GetById((Guid)reader["TipoPagtoId"]);
                    checkOut.Data = Convert.ToDateTime(reader["Data"]);
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
