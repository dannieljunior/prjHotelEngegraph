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
    public class RepositorioADOUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {

        public RepositorioADOUsuario()
        {
            _tabela = "Usuario";
        }

        public Usuario GetUserByLogin(string login)
        {
            var sql = $"SELECT * FROM Usuario WHERE login = '{login}'";
            var cmd = CriarComando(sql);
            return ObterLista(cmd).FirstOrDefault();
        }

        public Usuario Insert(Usuario obj)
        {
            //comando sql de insert
            var sql = @"INSERT INTO Usuario
                               (Id
                               ,Login
                               ,Senha
                               ,Email
                               ,Tentativas
                               ,Ativo
                               ,DataExpiracao
                               ,DataCriacao)
                         VALUES
                               (@Id
                               ,@Login
                               ,@Senha
                               ,@Email
                               ,@Tentativas
                               ,@Ativo
                               ,@DataExpiracao
                               ,@DataCriacao);";

            ExecutarComando(sql, obj);

            return obj;
        }

        public void Update(Usuario obj)
        {
            //comando sql de update
            var sql = @"UPDATE Usuario SET
                                Id = @Id
                               ,Login = @Login
                               ,Senha = @Senha
                               ,EMail = @EMail
                               ,Ativo = @Ativo
                               ,Tentativas = @tentativas
                               ,DataExpiracao = @DataExpiracao
                               ,DataModificacao = @DataModificacao
                        WHERE 
                               Id = @Id";

            ExecutarComando(sql, obj, EnOperacao.Update);
        }

        protected override Usuario ExecutarComando(string sql, Usuario obj, EnOperacao pOperacao = EnOperacao.Insert)
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
                        comando.Parameters.AddWithValue("Login", obj.Login);
                        comando.Parameters.AddWithValue("Senha", obj.Senha);
                        comando.Parameters.AddWithValue("Email", obj.EMail);
                        comando.Parameters.AddWithValue("Ativo", obj.Ativo);
                        comando.Parameters.AddWithValue("Tentativas", obj.Tentativas);
                        comando.Parameters.AddWithValue("DataExpiracao", obj.DataExpiracao);

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

        protected override List<Usuario> ObterLista(SqlCommand pComando)
        {
            var lista = new List<Usuario>();

            using (var reader = pComando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var checkOut = new Usuario();

                    checkOut.Id = (Guid)reader["Id"];
                    checkOut.Login = reader["Login"].ToString();
                    checkOut.Senha = reader["Senha"].ToString();
                    checkOut.EMail = reader["Email"].ToString();
                    checkOut.Ativo = Convert.ToInt32(reader["Ativo"]) == 0 ? false : true;
                    checkOut.Tentativas = Convert.ToInt32(reader["Tentativas"]);
                    checkOut.DataExpiracao = Convert.ToDateTime(reader["DataExpiracao"]);
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
