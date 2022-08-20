using Hotel.Bll.Classes;
using Hotel.Utils.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Migracoes
{
    public class CriaTabelaUh: MigracaoBase
    {
        public CriaTabelaUh()
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
