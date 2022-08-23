using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_9_CriaTabelaConfiguracao : MigracaoBase
    {
        public M_9_CriaTabelaConfiguracao()
        {
            versao = 9;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Configuracao"))
            {
                var sql = @"CREATE TABLE Configuracao(
	                        Id uniqueidentifier NOT NULL primary key,
	                        Codigo int NOT NULL,
	                        Descricao varchar(75) NOT NULL,
	                        Valor varchar(400) NOT NULL default '',
	                        DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL
                        );";

                comando.CommandText = sql;

                comando.ExecuteNonQuery();
            }
        }
    }
}
