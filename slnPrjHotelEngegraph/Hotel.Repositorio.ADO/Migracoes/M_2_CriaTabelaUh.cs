using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_2_CriaTabelaUh: MigracaoBase
    {
        public M_2_CriaTabelaUh()
        {
            versao = 2;
        }

        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Uh"))
            {
                var sqlCriaTabela = @"CREATE TABLE Uh(
	                        Id uniqueidentifier NOT NULL primary key,
	                        Numero varchar(15) NOT NULL,
	                        Bloco varchar(15) NULL,
	                        Nivel varchar(15) NULL default 'terreo',
	                        TipoUhId uniqueidentifier NOT NULL,
	                        Situacao smallint NOT NULL default 0);";

                comando.CommandText = sqlCriaTabela;
                comando.ExecuteNonQuery();

                var sqlCriaFk = @"ALTER TABLE dbo.Uh  WITH CHECK ADD FOREIGN KEY(TipoUhId)
                        REFERENCES dbo.TipoUh (Id)";

                comando.CommandText = sqlCriaFk;
                comando.ExecuteNonQuery();
            }
        }
    }
}
