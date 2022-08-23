using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_7_CriaTabelaHospedeOcupacao : MigracaoBase
    {
        public M_7_CriaTabelaHospedeOcupacao()
        {
            versao = 7;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("HospedeOcupacao"))
            {
                var sql = @"CREATE TABLE HospedeOcupacao(
	                        Id uniqueidentifier NOT NULL primary key,
	                        HospedeId uniqueidentifier NOT NULL,
	                        OcupacaoId uniqueidentifier NOT NULL,
	                        DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL
                        );";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE dbo.HospedeOcupacao  WITH CHECK ADD FOREIGN KEY(HospedeId)
                        REFERENCES dbo.Hospede (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE dbo.HospedeOcupacao  WITH CHECK ADD FOREIGN KEY(OcupacaoId)
                        REFERENCES dbo.Ocupacao (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
