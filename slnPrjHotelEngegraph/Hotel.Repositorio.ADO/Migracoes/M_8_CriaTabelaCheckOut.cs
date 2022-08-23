using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_8_CriaTabelaCheckOut : MigracaoBase
    {
        public M_8_CriaTabelaCheckOut()
        {
            versao = 8;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("CheckOut"))
            {
                var sql = @"CREATE TABLE CheckOut(
	                        Id uniqueidentifier NOT NULL primary key,
	                        DataCheckOut datetime NOT NULL,
	                        OcupacaoId uniqueidentifier NOT NULL,
	                        TipoPagtoId uniqueidentifier NOT NULL,
	                        DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL
                        );";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE dbo.CheckOut  WITH CHECK ADD FOREIGN KEY(OcupacaoId)
                        REFERENCES dbo.Ocupacao (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE dbo.CheckOut  WITH CHECK ADD FOREIGN KEY(TipoPagtoId)
                        REFERENCES dbo.TipoPagto (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
