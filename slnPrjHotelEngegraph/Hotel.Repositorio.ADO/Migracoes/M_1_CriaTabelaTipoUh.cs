using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_1_CriaTabelaTipoUh : MigracaoBase
    {
        public M_1_CriaTabelaTipoUh()
        {
            versao = 1;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("TipoUh"))
            {
                var sql = @"CREATE TABLE TipoUh(
	                        Id uniqueidentifier NOT NULL primary key,
	                        Descricao varchar(40) NOT NULL,
	                        QtdeAdt int NOT NULL default 0,
	                        QtdeChd int NOT NULL default 0,
	                        ValorDiaria numeric(14, 2) NOT NULL default 0.00,
	                        ValorAdicional numeric(14, 2) NOT NULL default 0.00,
	                        DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL
                        )";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
