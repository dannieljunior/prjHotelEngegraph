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
    public class RepositorioADOHospede : RepositorioBase<Hospede>, IRepositorioHospede
    {
        public RepositorioADOHospede()
        {
            _tabela = "Hospede";
        }

        public Hospede Insert(Hospede obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO Hospede
                               (Id
                               ,Nome
                               ,SobreNome
                               ,DataNascimento
                               ,Genero
                               ,NumeroDocumento
                               ,Telefone
                               ,Endereco
                               ,IsEstrangeiro
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Nome
                               ,@SobreNome
                               ,@DataNascimento
                               ,@Genero
                               ,@NumeroDocumento
                               ,@Telefone
                               ,@Endereco
                               ,@IsEstrangeiro
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(Hospede obj)
        {
            //comando sql de update
            var sql = @"UPDATE Hospede SET
                                Nome = @Nome
                               ,SobreNome = @SobreNome
                               ,DataNascimento = @DataNascimento
                               ,Genero = @Genero
                               ,NumeroDocumento = @NumeroDocumento
                               ,Telefone = @Telefone
                               ,Endereco = @Endereco
                               ,IsEstrangeiro = @IsEstrangeiro
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Hospede ExecutarComando(string sql, Hospede obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("Nome", obj.Nome);
                        comando.Parameters.AddWithValue("SobreNome", obj.SobreNome);
                        comando.Parameters.AddWithValue("DataNascimento", obj.DataNascimento);
                        comando.Parameters.AddWithValue("Genero", obj.Genero);
                        comando.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                        comando.Parameters.AddWithValue("Telefone", obj.Telefone);
                        comando.Parameters.AddWithValue("Endereco", obj.Endereco);
                        comando.Parameters.AddWithValue("IsEstrangeiro", obj.IsEstrangeiro);

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

        protected override List<Hospede> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Hospede>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var hospede = new Hospede();

                    hospede.Id = (Guid)reader["Id"];
                    hospede.Nome = reader["Nome"].ToString();
                    hospede.SobreNome = reader["SobreNome"].ToString();
                    hospede.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    hospede.Genero = (EnGenero)Convert.ToInt32(reader["Genero"]);
                    hospede.Telefone = reader["NumeroTelefone"].ToString();
                    hospede.Telefone = reader["Telefone"].ToString();
                    hospede.Endereco = reader["Endereco"].ToString();
                    hospede.IsEstrangeiro = (bool)reader["IsEstrangeiro"];
                    hospede.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                    if (reader["DataModificacao"] != DBNull.Value)
                        hospede.DataModificacao = Convert.ToDateTime(reader["DataModificacao"]);

                    lista.Add(hospede);
                }
            }

            return lista;
        }
    }
}
