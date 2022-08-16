using Hotel.Bll.Interfaces;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public class TipoUhBll : BllBase<TipoUh>, IBll<TipoUh>
    {

        public TipoUhBll(SqlConnection pConexao): base(pConexao)
        {
        }

        public void Delete(Guid id)
        {
            var sql = @"DELETE FROM TipoUh 
                        WHERE 
                            Id = @Id";

            ExecutarComando(sql, new TipoUh() { Id = id }, EnOperacao.Delete);
        }

        public void Insert(TipoUh obj)
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
        }

        public List<TipoUh> List()
        {
            var sql = "SELECT * FROM TipoUh";

            var comando = CriarComando(sql);

            return ObterLista(comando);
        }


        public DataTable ObterTabela()
        {
            var sql = "SELECT * FROM TipoUh";
            var comando = CriarComando(sql);
            var adapter = new SqlDataAdapter(comando);
            DataTable resultado = new DataTable();
            adapter.Fill(resultado);
            return resultado;
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

        public ObjetoDeValidacao Validar(TipoUh objeto)
        {
            var result = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Descricao))
            {
                result.Criticas.Add("Descrição deve ser informada.");
            }

            if(objeto.QtdeAdt <= 0)
            {
                result.Criticas.Add("Quantidade de adultos deve ser maior que zero.");
            }

            if(objeto.QtdeChd < 0)
            {
                result.Criticas.Add("Quantidade de crianças não pode ser negativa.");
            }

            if(objeto.ValorDiaria <= 0)
            {
                result.Criticas.Add("Valor da diária deve ser informado");
            }

            if (objeto.ValorAdicional < 0)
            {
                result.Criticas.Add("Valor adicional não pode ser um valor negativo.");
            }

            return result;
        }

        protected override void ExecutarComando(string sql, TipoUh obj, EnOperacao pOperacao = EnOperacao.Insert)
        {
            //instancia um novo SqlCommand
            var comando = CriarComando(sql);

            //Adiciona parametros com o seus respectivos valores
            
            if(pOperacao == EnOperacao.Delete)
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

                    if (pOperacao == EnOperacao.Insert)
                    {
                        var novoId = Guid.NewGuid();
                        comando.Parameters.AddWithValue("Id", novoId);
                        comando.Parameters.AddWithValue("DataCriacao", agora);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("DataModificacao", agora);
                    }
                }
            }

            //Executa um comando de NÃO consulta
            comando.ExecuteNonQuery();
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
