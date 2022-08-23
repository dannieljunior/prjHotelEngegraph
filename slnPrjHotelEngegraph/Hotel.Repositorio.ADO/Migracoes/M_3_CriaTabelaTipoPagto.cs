using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_3_CriaTabelaTipoPagto : MigracaoBase
    {
        public M_3_CriaTabelaTipoPagto()
        {
            versao = 3;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("TipoPagto"))
            {
                var sql = @"CREATE TABLE TipoPagto(
                            Id uniqueidentifier NOT NULL primary key,
                            Descricao varchar(40) NOT NULL,
                            DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL,
                         )";

                comando.CommandText = sql;

                comando.ExecuteNonQuery();
            }
        }
    }
}
