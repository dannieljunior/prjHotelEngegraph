using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_5_CriaTabelaOcupacao : MigracaoBase
    {
        public M_5_CriaTabelaOcupacao()
        {
            versao = 5;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Ocupacao"))
            {
                var sql = @"CREATE TABLE Ocupacao(
	                            Id uniqueidentifier NOT NULL primary key,
	                            DataCheckIn datetime NOT NULL,
	                            ReservaId uniqueidentifier NOT NULL,
	                            Situacao smallint NOT NULL default 1,
	                            DataCriacao datetime NOT NULL,
	                            DataModificacao datetime NULL
                            );";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE dbo.Ocupacao  WITH CHECK ADD FOREIGN KEY(ReservaId)
                        REFERENCES dbo.Reserva (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
