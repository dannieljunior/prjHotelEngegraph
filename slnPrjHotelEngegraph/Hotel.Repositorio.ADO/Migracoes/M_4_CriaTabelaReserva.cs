using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_4_CriaTabelaReserva : MigracaoBase
    {
        public M_4_CriaTabelaReserva()
        {
            versao = 4;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Reserva"))
            {
                var sql = @"CREATE TABLE Reserva(
	                            Id uniqueidentifier NOT NULL primary key,
	                            DataCheckIn datetime NOT NULL,
	                            DataCheckOut datetime NOT NULL,
	                            QtdeAdt smallint NOT NULL,
	                            QtdeChd smallint NOT NULL default 0,
	                            TipoUhId uniqueidentifier NOT NULL,
	                            Observacoes varchar(200) NULL,
	                            Situacao smallint NOT NULL default 0, 
	                            DataCriacao datetime NOT NULL,
	                            DataModificacao datetime NULL
                            );";

                comando.CommandText = sql;

                sql = @"ALTER TABLE dbo.Reserva  WITH CHECK ADD FOREIGN KEY(TipoUhId)
                        REFERENCES dbo.TipoUh (Id);";

                comando.ExecuteNonQuery();
            }
        }
    }
}
