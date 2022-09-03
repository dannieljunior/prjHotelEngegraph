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
    public class RepositorioADOUh : RepositorioBase<Uh>, IRepositorioUh
    {
        public RepositorioADOUh()
        {
            _tabela = "Uh";
        }

        public Uh Insert(Uh obj)
        {

        //comando sql de insert
            var sql = @"INSERT INTO Uh
                               (Id
                               ,Numero
                               ,Bloco
                               ,Nivel
                               ,TipoUhId
                               ,Situacao
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Numero
                               ,@Bloco
                               ,@Nivel
                               ,@TipoUhId
                               ,@Situacao
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public List<Uh> ObterUhsPorTipo(Guid tipoUhId)
        {
            var sql = $@"SELECT * FROM Uh WHERE TipoUhId = '{tipoUhId}'";

            var comando = CriarComando(sql);

            return ObterLista(comando);
        }

        public void Update(Uh obj)
        {
            //comando sql de update
            var sql = @"UPDATE Uh SET
                                   Numero = @Numero
                                   ,Bloco = @Bloco
                                   ,Nivel = @Nivel
                                   ,TipoUhId = @TipoUhId
                                   ,Situacao = @Situacao
                                   ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Uh ExecutarComando(string sql, Uh obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("Numero", obj.Numero);
                        comando.Parameters.AddWithValue("Bloco", obj.Bloco);
                        comando.Parameters.AddWithValue("Nivel", obj.Nivel);
                        comando.Parameters.AddWithValue("TipoUhId", obj.TipoUh.Id);
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

        protected override List<Uh> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Uh>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var Uh = new Uh();

                    Uh.Id = (Guid)reader["Id"];
                    Uh.Numero = reader["Numero"].ToString();
                    Uh.Bloco = reader["Bloco"].ToString();
                    Uh.Nivel = reader["Nivel"].ToString();
                    Uh.TipoUh = new RepositorioADOTipoUh().GetById((Guid)reader["TipoUhId"]);
                    Uh.Situacao = (EnSituacaoUh)Convert.ToInt32(reader["Situacao"]);
                    Uh.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        Uh.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(Uh);
                }
            }

            return lista;
        }
    }
}
