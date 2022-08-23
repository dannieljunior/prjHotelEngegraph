using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_6_CriaTabelaHospede : MigracaoBase
    {
        public M_6_CriaTabelaHospede()
        {
            versao = 6;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Hospede"))
            {
                var sql = @"CREATE TABLE Hospede(
	                            Id uniqueidentifier NOT NULL primary key,
	                            Nome varchar(40) NOT NULL,
	                            SobreNome varchar(40) NOT NULL,
	                            DataNascimento datetime NOT NULL,
	                            Genero smallint NOT NULL,
	                            NumeroDocumento varchar(40) NOT NULL,
	                            Telefone varchar(15) NOT NULL,
	                            Endereco varchar(200) NOT NULL,
	                            IsEstrangeiro smallint NOT NULL default 0,
	                            DataCriacao datetime NOT NULL,
	                            DataModificacao datetime NULL
                            );";

                comando.CommandText = sql;

                comando.ExecuteNonQuery();
            }
        }
    }
}
