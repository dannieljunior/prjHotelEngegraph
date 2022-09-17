using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_17_CriaTabelaUsuario : MigracaoBase
    {
        public M_17_CriaTabelaUsuario()
        {
            versao = 17;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Usuario"))
            {
                var sql = @"CREATE TABLE Usuario(
	                        Id uniqueidentifier NOT NULL primary key,
	                        Login varchar(40) NOT NULL,
                            Senha varchar(200) NOT NULL,
	                        Email varchar(100) NOT NULL,
                            Ativo smallint NOT NULL default 1,
                            Tentativas smallint NOT NULL default 0,
                            DataExpiracao datetime NOT NULL,
                            DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL)";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
